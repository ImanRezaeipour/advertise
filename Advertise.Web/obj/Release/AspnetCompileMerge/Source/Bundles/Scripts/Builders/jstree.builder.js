/**
 * 
 * @param {} elem 
 * @returns {} 
 */
var treeCategory = function (elem, isEdit) {
    var treeOptions = {
        actionUrl: "/category/gettreeajax",
        parentSelector: "#ParentId",
        onlyCanSelectLeafNode: true
    }

    $(elem).appTree(treeOptions);
}

/**
 * 
 * @param {} elem 
 * @returns {} 
 */
var treeRole = function (elem, isEdit) {
    var treeOptions;
    if (isEdit === true) {
        treeOptions = {
            actionUrl: "/role/getrolepermissionlistajax",
            actionParams: { id: $('#Id').val() },
            parentSelector: "#ParentId",
            HasCheckbox: true,
            checkedListSelector: "#permissions"
        }
    } else {
        treeOptions = {
            actionUrl: "/role/getpermissionlistajax",
            parentSelector: "#ParentId",
            HasCheckbox: true,
            checkedListSelector: "#permissions"
        }
    }

    $(elem).appTree(treeOptions);
}

/**
 * 
 * @param {} elem 
 * @returns {} 
 */
var treeCategoryProduct = function (elem, isEdit) {
    debugger;
    var treeOptions = {
        actionUrl: "/category/GetSubCatergoriesWithRootAjax",
        //parentSelector: "#CategoryId",
        actionParams: { id: $('#CategoryId').val() },
        //parentSelector: "#CategoryId",
        onlyCanSelectLeafNode: true

    }

    $(elem).appTree(treeOptions);
}


/**
 * 
 * @param {} elem 
 * @returns {} 
 */
var treeCategoryCompany = function (elem, isEdit) {
    debugger;
    var treeOptions = {
        actionUrl: "/category/gettreeajax",
        parentSelector: "#CategoryId",
        onlyCanSelectLeafNode: false

    }

    $(elem).appTree(treeOptions);
}


/**
 * 
 * @param {} elem 
 * @returns {} 
 */
var treeCategoryReview = function (elem, isEdit) {
    debugger;
    var treeOptions = {
        actionUrl: "/category/gettreeajax",
        parentSelector: "#CategoryId",
        onlyCanSelectLeafNode: false

    }

    $(elem).appTree(treeOptions);
}

/**
 * 
 * @param {} elem 
 * @returns {} 
 */
var treeCategorySpecification = function (elem, isEdit) {
    debugger;
    var treeOptions = {
        actionUrl: "/category/gettreeajax",
        parentSelector: "#CategoryId",
        onlyCanSelectLeafNode: false

    }

    $(elem).appTree(treeOptions);
}
/**
 * 
 * @param {} elem 
 * @returns {} 
 */
var treeCategorySpecificationOption = function (elem, isEdit) {
    debugger;
    var treeOptions = {
        actionUrl: "/category/gettreeajax",
        parentSelector: "#CategoryId",
        onlyCanSelectLeafNode: false

    }

    $(elem).appTree(treeOptions);
}