;(function($) {
    $.fn.appMap = function(options) {

        // catch this element
        var self = this;
        var elem = $(this);

        // default values
        var defaults = {
            elementId: "",
            defaultLatitude: $('#Address_Latitude').val(),
            defaultLongitude: $('#Address_Longitude').val(),
            latitudeSelector: "#Address_Latitude",
            longitudeSelector: "#Address_Longitude",
            showMarker: true
        }

        var settings = $.extend({}, defaults, options);

        // define functions
        function addMarker(event) {
            marker.setMap(null);

            var markerOptions = {
                position: event.latLng,
                map: map
            }

            marker = new google.maps.Marker(markerOptions);

            $(settings.latitudeSelector).val(event.latLng.lat);
            $(settings.longitudeSelector).val(event.latLng.lng);
        }

        // do work on element
        var marker;

        var defaultLocation = new google.maps.LatLng(settings.defaultLatitude, settings.defaultLongitude);

        if (settings.defaultLatitude === 0 || settings.defaultLongitude === 0) {
            if (navigator.geolocation) {
                navigator.geolocation.getCurrentPosition(function(position) {
                    defaultLocation = new google.maps.LatLng(position.coords.latitude, position.coords.longitude);

                    $(settings.latitudeSelector).val(position.coords.latitude);
                    $(settings.longitudeSelector).val(position.coords.longitude);
                });
            }
        }

        var mapOptions = {
            center: defaultLocation,
            zoom: 18
        }

        var map = new google.maps.Map(document.getElementById(settings.elementId), mapOptions);

        if (settings.showMarker === true) {
            var markerOptions = {
                position: defaultLocation,
                map: map
            }

            marker = new google.maps.Marker(markerOptions);

            map.addListener('click', function(event) {
                    addMarker(event);
                });
        }

        // return element
        return elem;
    }
}(jQuery));


(function ($) {
    $.fn.appMapCluster = function (options) {

        // catch this element
        var self = this;
        var elem = $(this);

        // default variables
        var defaults = {
            elementId: ""
        }

        var settings = $.extend({}, defaults, options);

        // define functions
        function getMarkers(locations) {
            console.log(locations);
            var markers = locations.map(function (location, i) {
                var infowindowOptions = {
                    content: '<b>فروشگاه:</b> <a href="/company-detail.html?code=' + location.Code + '">' + location.Title + '</a> <br>' +
                        '<b>نوع فعالیت:</b> <a href="/category-detail.html?code=' + location.CategoryCode + '">' + location.CategoryTitle + '</a> <br>' +
                        '<b>توضیحات:</b>' + location.Description + '<br>'
                }

                var markerOptions = {
                    position: {
                        lat: parseFloat(location.Latitude),
                        lng: parseFloat(location.Longitude)
                    },
                    title: location.Title,
                    info: new google.maps.InfoWindow(infowindowOptions)
                }

                var marker = new google.maps.Marker(markerOptions);

                marker.addListener('click', function () {
                    marker.info.open(map, marker);
                });

                return marker;
            });

            return markers;
        }

        function drawMarkers(locations) {
            var markerCluster = new MarkerClusterer(map, getMarkers(locations), {imagePath: '/Bundles/Vendors/GoogleMap/m'});
        }

        function getCurrentLocation() {
            if (navigator.geolocation) {
                navigator.geolocation.getCurrentPosition(function(position) {
                    var defaultLocation = new google.maps.LatLng(position.coords.latitude, position.coords.longitude);
                    return defaultLocation;
                });
            }

            var tehranLocation = {
                lat: parseFloat(35.694390),
                lng: parseFloat(51.421510)
            };
            return tehranLocation;
        }
        
        // do work on element
        var defaultLocation = getCurrentLocation();

        var mapOptions = {
            center: defaultLocation,
            zoom: 12
        }

        var map = new google.maps.Map(document.getElementById(settings.elementId), mapOptions);

        var ajaxOptions = {
            url: window.appCultureRoute + '/company/getalllistajax',
            data: {},
            type: 'GET',
            dataType: 'json',
            complete: function (xhr, status) {
                console.log(xhr);
                drawMarkers(xhr.responseJSON);
            }
        }

        $.ajax(ajaxOptions);
        
        // return element
        return elem;
    }
}(jQuery))