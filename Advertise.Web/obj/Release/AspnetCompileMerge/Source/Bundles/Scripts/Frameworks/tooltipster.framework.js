;(function($) {
    $.fn.appTooltip = function(options) {
        
        // capture this element
        var self = this;
        var elem = $(this);

        // default settings
        var defaults = {
            position: "bottom"
        }

        var settings = $.extend({}, defaults, options);

        // work on element
        var tooltipsterOptions = {
            animation: "grow",
            delay: 100,
            theme: 'tooltipster-light',
            interactive: true,
            position: settings.position
        }

        $(self).tooltipster(tooltipsterOptions);

        // return element
        return elem;
    }
}(jQuery))