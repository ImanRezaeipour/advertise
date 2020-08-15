;(function($) {
    $.fn.appUploader = function(options) {
        
        // capture this element
        var self = this;
        var elem = $(this);

        // default settings
        var defaults = {
            elementId: "files",
            modelId: "",
            initializeUrl: "",
            modelField: "",
            modelFieldIndex: "",
            isEditable: false,
            isMultiple: true,
            requestParams: {}
        }

        var settings = $.extend({}, defaults, options);

        // declare events
        function onCompleted(id, fileName, responseJSON) {
            if (responseJSON.success) {
                if (settings.isMultiple === false) {
                    if ($("#" + settings.elementId).find('input[data-index="0"]').length !== 0) {
                        $("#" + settings.elementId).find(':hidden').last().remove();
                        $("#" + settings.elementId).find(':hidden').last().remove();
                    }
                }

                if ($("#" + settings.elementId).find('input[data-index="0"]').length === 0) {
                    $("#" + settings.elementId).append('<input type="hidden" name="' + settings.modelFieldIndex + '" value="0">');
                    $("#" + settings.elementId).append('<input type="hidden" data-index="0" name="' + settings.modelField.replace('*', '0') + '" id="' + id + '" value="' + responseJSON.result[0].Name + '">');
                }
                else {
                    var lastIndex = $("#" + settings.elementId).find(':hidden').last().data('index');
                    var index = parseInt(lastIndex) + 1;
                    $("#" + settings.elementId).append('<input type="hidden" name="' + settings.modelFieldIndex + '" value="' + index + '">');
                    $("#" + settings.elementId).append('<input type="hidden" data-index="' + index + '" name="' + settings.modelField.replace('*', index) + '" id="' + id + '" value="' + responseJSON.result[0].Name + '">');
                }
            }
        };

        function onDeleted(id, xhr, isError) {
            if (isError === false) {
                $("#" + settings.elementId).find('input[data-index="' + id + '"]').prev().remove();
                $("#" + settings.elementId).find('input[data-index="' + id + '"]').remove();
            }
        };

        function onStarted(response, success, xhrOrXdr) {
            $.each(response,
                function (key, value) {
                    $("#" + settings.elementId).append('<input type="hidden" name="' + settings.modelFieldIndex + '" value="' + key + '">');
                    $("#" + settings.elementId).append('<input type="hidden" data-index="' + key + '" name="' + settings.modelField.replace('*', key) + '" id="' + value.uuid + '" value="' + value.name + '">');
                });
        };

        // do work on element
        debugger;
        var fineuploaderOptions = {
            element: document.getElementById(settings.elementId),
            template: 'qq-template-gallery',
           
            request: {
                endpoint: '/upload/save-image',
                params: settings.requestParams
            },
            validation: {
                allowedExtensions: ['jpeg', 'jpg', 'gif', 'png']
            },
            itemLimit: 1,
            multiple: settings.isMultiple,
            messages: {
                emptyError: "{file} is empty, please select files again without it.",
                maxHeightImageError: "Image is too tall.",
                maxWidthImageError: "Image is too wide.",
                minHeightImageError: "Image is not tall enough.",
                minWidthImageError: "Image is not wide enough.",
                minSizeError: "{file} is too small, minimum file size is {minSizeLimit}.",
                noFilesError: "No files to upload.",
                onLeave: "The files are being uploaded, if you leave now the upload will be canceled.",
                retryFailTooManyItemsError: "Retry failed - you have reached your file limit.",
                sizeError: "{file} is too large, maximum file size is {sizeLimit}.",
                tooManyItemsError: "Too many items ({netItems}) would be uploaded. Item limit is {itemLimit}.",
                typeError: "{file} has an invalid extension. Valid extension(s): {extensions}.",
                unsupportedBrowserIos8Safari: "Unrecoverable error - this browser does not permit file uploading of any kind due to serious bugs in iOS8 Safari. Please use iOS8 Chrome until Apple fixes these issues."
            },
            deleteFile: {
                enabled: true,
                endpoint: '/upload/remove-image'
            },
            callbacks: {
                onComplete: function(id, fileName, responseJSON) {
                    onCompleted(id, fileName, responseJSON);
                },
                onDeleteComplete: function(id, xhr, isError) {
                    onDeleted(id, xhr, isError);
                }
            }
        }

        if (settings.isEditable === true) {
            fineuploaderOptions.session = {
                endpoint: window.appCultureRoute + settings.initializeUrl,
                params: { id: settings.modelId }
            };
            fineuploaderOptions.callbacks.onSessionRequestComplete = function(response, success, xhrOrXdr) {
                onStarted(response, success, xhrOrXdr);
            }
        }
            
        var fineuploaderResult = new qq.FineUploader(fineuploaderOptions);

        // return element
        return elem;
    }
}(jQuery))