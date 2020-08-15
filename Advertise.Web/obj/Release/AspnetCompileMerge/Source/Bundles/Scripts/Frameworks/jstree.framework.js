; (function ($) {
    $.fn.appTree = function (options) {

        // catch this element
        var self = this;
        var elem = $(this);

        // default options
        var defaults = {
            actionUrl: "",
            actionParams: {},
            actionType: "GET",
            actionDataType: "json",
            parentSelector: "",
            checkedListSelector: "",
            HasCheckbox: false,
            onlyCanSelectLeafNode: false,
            afterCompleted: function () { }
        };

        var settings = $.extend({}, defaults, options);

        // define events
        function onCompleted(xhr, status) {
            var dataText = JSON.stringify(xhr.responseJSON);
            var dataSource = toJsTreeCheckBoxFlatDataSource(dataText);
            dataSource = JSON.parse(dataSource);

            var jstreeOptions = {
                core: {
                    data: dataSource
                },
                plugins: [
                    "search", "sort", "types", "unique", "wholerow", "changed", "conditionalselect"
                ],
                types: {
                    "None": {
                        "icon": "fa fa-sitemap"
                    },
                    "Service": {
                        "icon": "fa fa-coffee"
                    },
                    "Salable": {
                        "icon": "fa fa-shopping-bag"
                    }
                }

            }

            if (settings.HasCheckbox === true) {
                jstreeOptions.plugins.push("checkbox");
                jstreeOptions.checkbox = {
                    "keep_selected_style": false
                };
                jstreeOptions.core.expand_selected_onload = false;
            }

            if (settings.onlyCanSelectLeafNode === true) {
                jstreeOptions.conditionalselect = function (node, event) {
                    if (node.children.length > 0)
                        return false;
                    return true;
                }
            }

            $(self)
                .on('select_node.jstree', function (node, selected, event) {
                    var categoryId = selected.node.id;
                    $(settings.parentSelector).val(categoryId);
                })

                .on('loaded.jstree', function () {
                    var selectNode = '#'+ $(settings.parentSelector).val().toString();
                    $(self).jstree('deselect_all');
                    $(self).jstree('close_all');
                    $(self).jstree("open_node", selectNode);
                    $(self).jstree("select_node", selectNode);
                })

                .on('changed.jstree', function (e, data) {
                    if (settings.HasCheckbox === true) {
                        var checkedNodes = $(self).jstree("get_checked", false);
                        $(settings.checkedListSelector).val(checkedNodes.join(","));
                    }
                })

                .jstree(jstreeOptions);

            $(self).jstree("open_node", '#' + $(settings.parentSelector).val());
        }

        function toJsTreeCheckBoxFlatDataSource(data) {
            data = JSON.parse(data);
            var temp = JSON.parse('[]');
            $.each(data, function (key, value) {
                if (value.ParentId === null) {
                    temp.push({
                        id: value.Id,
                        text: value.Title,
                        type: value.Type,
                        parent: "#",
                        state: {
                            opened: false,
                            disabled: false,
                            selected: value.IsSelect
                        },
                        li_attr: {},
                        a_attr: {}
                    });
                } else {
                    temp.push({
                        id: value.Id,
                        text: value.Title,
                        type: value.Type,
                        parent: value.ParentId,
                        state: {
                            opened: false,
                            disabled: false,
                            selected: value.IsSelect
                        },
                        li_attr: {},
                        a_attr: {}
                    });
                }

            });
            return JSON.stringify(temp);
        }

        function toHierarchicalDataSource(data, idField, foreignKey, rootLevel) {
            var hash = {};
            for (var i = 0; i < data.length; i++) {
                var item = data[i];
                var id = item[idField];
                var parentId = item[foreignKey];
                hash[id] = hash[id] || [];
                hash[parentId] = hash[parentId] || [];
                item.children = hash[id];
                hash[parentId].push(item);
            }
            return hash[rootLevel];
        }

        // do work and process on element
        var ajaxOptions = {
            url: window.appCultureRoute + settings.actionUrl,
            data: settings.actionParams,
            type: settings.actionType,
            dataType: settings.actionDataType,
            complete: function (xhr, status) {
                onCompleted(xhr, status);
                settings.afterCompleted();
            }
        };

        $.ajax(ajaxOptions);

        // return element
        return elem;
    };
}(jQuery));