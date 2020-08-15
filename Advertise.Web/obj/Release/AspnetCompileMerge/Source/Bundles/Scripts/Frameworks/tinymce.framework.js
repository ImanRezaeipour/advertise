;(function($) {
    $.fn.appEditor = function(options) {
        
        // capture this element
        var self = this;
        var elem = $(this);

        // define defaults
        var defaults = {
            
        }

        var settings = $.extend({}, defaults, options);

        // do work on element
        var tinymceOptions = {
            selector: 'textarea',
            directionality: 'rtl',
            language: 'fa_IR',
            branding: false,
            min_height: 440,
            min_width: 400,
            entity_encoding: "raw",
            skin: "lightgray",
            theme: 'modern',
            menubar: false,
            statusbar: true,
            toolbar:
                'bold italic underline strikethrough | alignleft aligncenter alignright alignjustify alignnone | ' +
                'styleselect formatselect fontselect fontsizeselect | cut copy paste | outdent indent blockquote undo redo'
        };

        var resultTinymce = tinymce.init(tinymceOptions);


    }
}(jQuery))