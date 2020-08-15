/**
 * 
 * @param {} key 
 * @param {} value 
 * @returns {} 
 */
var setQuryStringParameter = function (key, value) {
    window.history.pushState(null, null, setUrlEncodedKey(key, value));
    window.location.reload();
}

/**
 * 
 * @param {} name 
 * @param {} url 
 * @returns {} 
 */
var getUrlParameterByName = function(name, url) {
    if (!url) url = window.location.href;
    name = name.replace(/[\[\]]/g, "\\$&");
    var regex = new RegExp("[?&]" + name + "(=([^&#]*)|&|#|$)"),
        results = regex.exec(url);
    if (!results) return null;
    if (!results[2]) return '';
    return decodeURIComponent(results[2].replace(/\+/g, " "));
}

/**
 * 
 * @param {} uri 
 * @param {} key 
 * @param {} value 
 * @returns {} 
 */
var updateQueryStringParameter = function(uri, key, value) {
    var re = new RegExp("([?&])" + key + "=.*?(&|$)", "i");
    var separator = uri.indexOf('?') !== -1 ? "&" : "?";
    if (uri.match(re)) {
        return uri.replace(re, '$1' + key + "=" + value + '$2');
    }
    else {
        return uri + separator + key + "=" + value;
    }
}

/**
 * 
 * @param {} key 
 * @param {} query 
 * @returns {} 
 */
var getUrlEncodedKey = function (key, query) {
    if (!query)
        query = window.location.search;
    var re = new RegExp("[?|&]" + key + "=(.*?)&");
    var matches = re.exec(query + "&");
    if (!matches || matches.length < 2)
        return "";
    return decodeURIComponent(matches[1].replace("+", " "));
}

/**
 * 
 * @param {} key 
 * @param {} value 
 * @param {} query 
 * @returns {} 
 */
var setUrlEncodedKey = function (key, value, query) {

    query = query || window.location.search;
    var q = query + "&";
    var re = new RegExp("[?|&]" + key + "=.*?&");
    if (!re.test(q))
        q += key + "=" + encodeURI(value);
    else
        q = q.replace(re, "&" + key + "=" + encodeURIComponent(value) + "&");
    q = q.trimStart("&").trimEnd("&");
    return q[0] == "?" ? q : q = "?" + q;
}

/**
 * 
 * @param {} c 
 * @returns {} 
 */
String.prototype.trimEnd = function (c) {
    if (c)
        return this.replace(new RegExp(c.escapeRegExp() + "*$"), '');
    return this.replace(/\s+$/, '');
}

/**
 * 
 * @param {} c 
 * @returns {} 
 */
String.prototype.trimStart = function (c) {
    if (c)
        return this.replace(new RegExp("^" + c.escapeRegExp() + "*"), '');
    return this.replace(/^\s+/, '');
}

/**
 * 
 * @returns {} 
 */
String.prototype.escapeRegExp = function () {
    return this.replace(/[.*+?^${}()|[\]\/\\]/g, "\\$0");
}