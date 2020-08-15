/**
 * 
 * @param {} viewTypeParameter 
 * @returns {} 
 */
var switchViewType = function (viewTypeParameter) {
    switch (viewTypeParameter) {
        case "grid":
            $('.landing-items-wrapper').addClass('landing-grids-wrapper');
            $('.landing-grids-wrapper').removeClass('landing-items-wrapper');
            $('.item-view-holder').css('background-color', '#f6f6f6');
            $('.item-view-holder i').css('color', '#b0b0b0');
            $('.grid-view-holder').css('background-color', '#ebebeb');
            $('.grid-view-holder i').css('color', '#999');
            break;
        case "item":
            $('.landing-grids-wrapper').addClass('landing-items-wrapper');
            $('.landing-items-wrapper').removeClass('landing-grids-wrapper');
            $('.grid-view-holder').css('background-color', '#f6f6f6');
            $('.grid-view-holder i').css('color', '#b0b0b0');
            $('.item-view-holder').css('background-color', '#ebebeb');
            $('.item-view-holder i').css('color', '#999');
            break;
    }
}

/**
 * 
 * @param {} elem 
 * @returns {} 
 */
var renderView = function (elem) {
    var currentViewType = $(elem).data('param');
    switchViewType(currentViewType);
    buildPageLS(currentViewType);
}

/**
 * 
 * @returns {} 
 */
var showList = function () {
    $('.landing-items-wrapper').show();
    $('.landing-grids-wrapper').show();
}

/**
 *
 * @param {} e
 * @param {} elem
 * @returns {}
 */
var refreshCaptcha = function (e, elem) {
    e.preventDefault();
    var d = new Date();
    var ticks = ((d.getTime() * 10000) + 621355968000000000);
    $('#imageCaptcha').attr('src', window.appCultureRoute + '/home/CaptchaImage/' + ticks);
}

/**
 * function that gathers IDs of checked nodes
 * @param {} nodes
 * @param {} checkedNodes
 * @returns {}
 */
var checkedNodeIds = function (nodes, checkedNodes) {
    for (var i = 0; i < nodes.length; i++) {
        if (nodes[i].checked) {
            checkedNodes.push(nodes[i].id);
        }

        if (nodes[i].hasChildren) {
            //checkedNodes.push(nodes[i - 1].id);
            checkedNodeIds(nodes[i].children.view(), checkedNodes);
        }
    }
}

/**
 *
 * @param {} event
 * @param {} elem
 * @returns {}
 */
var addSpecificationoption = function (elem) {
    //event.preventDefault();
    var index = $("#items #item").last().data("index");

    $("#items #item").first().clone().appendTo("#items");
    $("#items #item").last().attr("data-index", (parseInt(index) + 1));

    $("#items #item").last().find('*').each(function (key, value) {
        if ($(this).attr('value') != null)
            $(this).val('');
        if ($(this).attr('name') != null)
            $(this).attr('name', $(this).attr('name').replace('\[0\]', '\[' + (parseInt(index) + 1) + '\]'));
        if ($(this).attr('id') != null)
            $(this).attr('id', $(this).attr('id').replace('_0_', '_' + (parseInt(index) + 1) + '_'));
        if ($(this).attr('for') != null)
            $(this).attr('for', $(this).attr('for').replace('_0_', '_' + (parseInt(index) + 1) + '_'));
        if ($(this).attr('data-valmsg-for') != null)
            $(this).attr('data-valmsg-for', $(this).attr('data-valmsg-for').replace('\[0\]', '\[' + (parseInt(index) + 1) + '\]'));
        if ($(this).attr('data-param') != null)
            $(this).attr('data-param', $(this).attr('data-param').replace('0', (parseInt(index) + 1)));
        if ($(this).attr('value') != null)
            $(this).val(parseInt(index) + 1);
        if ($(this).attr('data-action') != null)
            $(this).click(function () { removeSpecificationoption(event, this); });
    });

    $("#items #item").last().find('input[type=text]').val('');
}

/**
 *
 * @param {} event
 * @param {} elem
 * @returns {}
 */
var removeSpecificationoption = function (elem) {
    //event.preventDefault();
    var index = $(elem).data('param');
    if (index !== 0)
        $("#items #item").remove("[data-index='" + index + "']");
}

/**
 *
 * @param {} elem
 * @returns {}
 */
var findTotalBagPrice = function (elem) {
    var final = 0;
    $(elem).each(function () {
        final = final + parseInt($(this).attr('data-val'));
    });
    return (final);
}

/**
 * 
 * @param {} tag 
 * @returns {} 
 */
var redirect = function (tag) {
    var id = $(tag).data('param');
    var url = $(tag).data('url');
    //var dd = url + '?=' + id ;
    window.open(url + '?id=' + id);
}

/**
 * 
 * @param {} elem 
 * @returns {} 
 */
var checkNumber = function (elem) {
    // Allow: backspace, delete, tab, escape, enter and .
    if ($.inArray(e.keyCode, [46, 8, 9, 27, 13, 110, 190]) !== -1 ||
        // Allow: Ctrl+A, Command+A
        (e.keyCode === 65 && (e.ctrlKey === true || e.metaKey === true)) ||
        // Allow: home, end, left, right, down, up
        (e.keyCode >= 35 && e.keyCode <= 40)) {
        // let it happen, don't do anything
        return;
    }
    // Ensure that it is a number and stop the keypress
    if ((e.shiftKey || (e.keyCode < 48 || e.keyCode > 57)) && (e.keyCode < 96 || e.keyCode > 105)) {
        e.preventDefault();
    }
};

/**
 *
 * @param {} e
 * @param {} elem
 * @returns {}
 */
var searchTerm = function (e, elem) {
    e = e || window.event;
    if (e.keyCode === 13) {
        var term = $(elem).val();
        if (document.location === window.appCultureRoute + '/product/search') {
            document.location = setUrlEncodedKey("t", term);
            onAjaxLoadNavigator();
        }
        else {
            document.location = window.appCultureRoute + '/product/search';
            document.location = setUrlEncodedKey("t", term);
            onAjaxLoadNavigator();
        }
        return false;
    }
    return true;
}

/**
 *
 * @param {} elem
 * @returns {}
 */
var changeSearchTerm = function (e, elem) {
    e = e || window.event;
    if (e.keyCode === 13) {
        var term = $('#searchProduct').val();
        var newLink = window.appCultureRoute + '/product/search' + '?t=' + term;
        window.location = newLink;
        return false;
    }
    return true;
}

/**
 *
 * @param {} elem
 * @returns {}
 */
var searchOnLanding = function (elem) {
    var term = $('#navSearchProduct').val();
    var cat = $('#navCategories').val();
    var newLink = window.appCultureRoute + '/product/search' + '?t=' + term + '&c=' + cat;

    $(elem).attr('href', newLink);
}

/**
 *
 * @returns {}
 */
var goUp = function () {
    $('#goUpBtn').click(function (e) {
        $('body,html').animate({ scrollTop: 0 }, 600);
    });
    $(window).scroll(function () {
        if ($(this).scrollTop() > 140) {
            $('#goUpBtn').addClass('goUpAnimate');
        } else {
            $('#goUpBtn').removeClass('goUpAnimate');
        }
    });
};

/**
 *
 * @returns {}
 */
var navMove = function () {
    $(window).scroll(function () {
        var x = 0;
        if ($(this).scrollTop() > 100) {
            x = 1;
        }
        if (x == 1) {
            $('.main-menu-wrap').addClass('navMenuFixed');
            $('#SiteMap').css('margin-top', '40px');
        } else {
            $('.main-menu-wrap').removeClass('navMenuFixed');
            $('#SiteMap').css('margin-top', '0');
        }
    });
};

/**
 *
 * @param {} elem
 * @returns {}
 */
var openModal = function (elem) {
    var img = $(elem).children().attr('src');
    $('.company-modal').show();
    $('.modal-img-wrapper').show();
    $('.modal-img-wrapper').children().attr('src', img);
    var h = $(window).height() * .8;
    var ih = $('#modal-image').height();
    var marg = (h - ih) / 2;
    $('#modal-image').css('margin-top', marg);
}

/**
 *
 * @param {} elem
 * @returns {}
 */
var closeModal = function (elem) {
    $('.company-modal').hide();
    $('.modal-img-wrapper').hide();
}

/**
 *
 * @param {} elem
 * @returns {}
 */
var showCompanyTab = function (elem) {
    $(".activated").removeClass("activated");
    var sectionClass = "." + $(elem).data("section");
    $(sectionClass).addClass("activated");
}

/**
 *
 * @param {} event
 * @param {} elem
 * @returns {}
 */
var addFeatures = function (elem) {
    //event.preventDefault();
    var index = $("#items #item").last().data("index");

    $("#items #item").first().clone().appendTo("#items");
    $("#items #item").last().attr("data-index", (parseInt(index) + 1));

    $("#items #item").last().find('*').each(function (key, value) {
        if ($(this).attr('value') != null)
            $(this).val('');
        if ($(this).attr('name') != null)
            $(this).attr('name', $(this).attr('name').replace('\[0\]', '\[' + (parseInt(index) + 1) + '\]'));
        if ($(this).attr('id') != null)
            $(this).attr('id', $(this).attr('id').replace('_0_', '_' + (parseInt(index) + 1) + '_'));
        if ($(this).attr('for') != null)
            $(this).attr('for', $(this).attr('for').replace('_0_', '_' + (parseInt(index) + 1) + '_'));
        if ($(this).attr('data-valmsg-for') != null)
            $(this).attr('data-valmsg-for', $(this).attr('data-valmsg-for').replace('\[0\]', '\[' + (parseInt(index) + 1) + '\]'));
        if ($(this).attr('data-param') != null)
            $(this).attr('data-param', $(this).attr('data-param').replace('0', (parseInt(index) + 1)));
        if ($(this).attr('value') != null)
            $(this).val(parseInt(index) + 1);
        if ($(this).attr('data-action') != null)
            $(this).click(function () { removeFeatures(event, this); });
    });

    $("#items #item").last().find('input[type=text]').val('');
}

/**
 *
 * @param {} event
 * @param {} elem
 * @returns {}
 */
var removeFeatures = function (elem) {
    //event.preventDefault();
    var index = $(elem).data('param');
    if (index !== 0)
        $("#items #item").remove("[data-index='" + index + "']");
}

/**
 *
 * @param {} elem
 * @returns {}
 */
var selectSubCategory = function (elem) {
    var id = $(elem).closest('li').attr('value');
    $('#categoryId').val(id);
    $(elem).closest('ul').children().removeClass('active');
    $(elem).closest('li').addClass('active');
    window.history.pushState(null, null, setUrlEncodedKey("c", id));
    fillSearchProducts();
}

/**
 *
 * @param {} elem
 * @returns {}
 */
var loadCategory = function (elem) {
    var categoryId = getUrlParameterByName('c');
    if (categoryId === null || categoryId === '') {
        categoryId = $('#categoryId').val();
    }
    else {
        $('#categoryId').val(categoryId);
        $(elem).val(categoryId);
    }
}

/**
 *
 * @param {} elem
 * @returns {}
 */
var selectSortMemberFilter = function (elem) {
    var value = $(elem).find(':selected').val();

    $('#sortmember').val(value);

    window.history.pushState(null, null, setUrlEncodedKey("m", value));

    fillSearchProducts();
}

/**
 *
 * @param {} elem
 * @returns {}
 */
var selectSortDirectionFilter = function (elem) {
    var value = $(elem).find(':selected').val();

    $('#sortDirection').val(value);

    window.history.pushState(null, null, setUrlEncodedKey("d", value));

    fillSearchProducts();
}

/**
 *
 * @param {} elem
 * @returns {}
 */
var selectPageSizeFilter = function (elem) {
    var value = $(elem).find(':selected').val();

    $('#pageSize').val(value);

    window.history.pushState(null, null, setUrlEncodedKey("ps", value));

    fillSearchProducts();
}

/**
 *
 * @param {} elem
 * @returns {}
 */
var selectPageFilter = function (elem) {
    var page = parseInt($(elem).text());

    $('.pager').children().removeClass('active');

    $(elem).parent().addClass('active');

    $('#page').val(page);

    fillSearchProducts();
}

/**
 *
 * @param {} elem
 * @returns {}
 */
var productSearchPagination = function () {
    var totalCount = $('#total').val();
    var pageSize = $('#pageSize').val();
    var totalPage = parseInt((totalCount / pageSize) + 1);

    var initPage = getUrlParameterByName('p');
    if (initPage === null || initPage === '') {
        initPage = $('#page').val();
    }
    else if (initPage > totalPage) {
        initPage = totalPage;
        $('#page').val(initPage);
    }
    else {
        $('#page').val(initPage);
    }

    if ($('#productSearchPager').data("twbs-pagination")) {
        $('#productSearchPager').twbsPagination('destroy');
    }

    $('#productSearchPager').twbsPagination({
        totalPages: totalPage,
        visiblePages: 5,
        startPage: parseInt(initPage),
        first: '<< اولین',
        prev: '< قبلی',
        next: 'بعدی >',
        last: 'آخرین >>',
        href: false,
        initiateStartPageClick: false,
        onPageClick: function (event, page) {
            $('#page').val(page);
            window.history.pushState(null, null, setUrlEncodedKey("p", page));
            fillSearchProducts();
        }
    });
}

/**
 *
 * @param {} elem
 * @returns {}
 */
var loadCity = function (elem) {
    var stateId = getUrlParameterByName('s');
    if (stateId === null || stateId === '') {
        stateId = $('#stateId').val();
    }
    else {
        $('#stateId').val(stateId);
        $(elem).val(stateId);
    }
}

/**
 *
 * @param {} elem
 * @returns {}
 */
var selectSearchCity = function (elem) {
    var selectedId = $(elem).find(':selected').val();
    if (selectedId === '-1') {
        $('#stateId').val('');
        window.history.pushState(null, null, setUrlEncodedKey("s", ''));
    }
    else {
        $('#stateId').val(selectedId);
        window.history.pushState(null, null, setUrlEncodedKey("s", selectedId));
    }

    var id = $('#stateId').val();

    fillSearchProducts();
}

/**
 *
 * @returns {}
 */
var slideSize = function () {
    var count = $('#imgCount').data('param') + $('#previewCheck').data('param');
    $('#imgCount').attr('data-number', (count - 4).toString());
    var percent = (100 / count).toString() + '%';
    $('.slide-holder').css('width', percent);
    if (count < 5) {
        $('.sliders-container').css('width', '100%');
        $('.slide-controller-right').children().addClass('slide-deactivated');
        $('.slide-controller-left').children().addClass('slide-deactivated');
    } else {
        var w = ((count - 4) * 25 + 100).toString() + '%';
        $('.sliders-container').css('width', w);
    }
}

/**
 *
 * @returns {}
 */
var nextSlideImg = function () {
    var count = $('#imgCount').data('param') + $('#previewCheck').data('param');
    var no = $('#imgCount').attr('data-number');
    var w = parseInt($('.sliders-wrapper').css('width'));
    var left = parseInt($('.sliders-container').css('left'));
    var remain = count - 4;
    if (remain > 0 && no > 0) {
        var newLeft = (left - (w / 4)).toString() + 'px';
        $('.sliders-container').css('left', newLeft);
        $('#imgCount').attr('data-number', (no - 1).toString());
        --no;
    } else if (remain > 0 && no == 0) {
        $('.sliders-container').css('left', '0px');
        $('#imgCount').attr('data-number', (remain).toString());
        no = remain;
    }
}

/**
 *
 * @returns {}
 */
var prevSlideImg = function () {
    var count = $('#imgCount').data('param') + $('#previewCheck').data('param');
    var no = $('#imgCount').attr('data-number');
    var w = parseInt($('.sliders-wrapper').css('width'));
    var left = parseInt($('.sliders-container').css('left'));
    var remain = count - 4;
    if (remain > 0 && no < remain) {
        var newLeft = (left + (w / 4)).toString() + 'px';
        $('.sliders-container').css('left', newLeft);
        $('#imgCount').attr('data-number', (parseInt(no) + 1).toString());
        ++no;
    } else if (remain > 0 && no == remain) {
        $('.sliders-container').css('left', (-(remain * 25)).toString() + '%');
        $('#imgCount').attr('data-number', '0');
        no = 0;
    }
}

/**
 *
 * @param {} elem
 * @returns {}
 */
var resizeSlide = function (elem) {
    var src = $(elem).attr('src');
    $('#slideBgImg').attr('src', src);
}

/**
 * 
 * @returns {} 
 */
var enableSubmitButton = function () {
    $(':submit').removeClass('disabled-btn-link');
    $(':submit').prop('disabled', false);
}

/**
 * 
 * @param {} event 
 * @param {} tag 
 * @returns {} 
 */
var addSpecOption = function (tag) {
    //event.preventDefault();
    var items = $(tag).data('items');
    var item = $(tag).data('item');
    var index = $(item).last().data("index");

    $(item).first().clone().appendTo(items);
    $(item).last().attr("data-index", (parseInt(index) + 1));

    $(item).last().find('*').each(function (key, value) {
        if ($(this).attr('value') != null)
            $(this).val('');
        if ($(this).attr('name') != null)
            $(this).attr('name', $(this).attr('name').replace('\[0\]', '\[' + (parseInt(index) + 1) + '\]'));
        if ($(this).attr('id') != null)
            $(this).attr('id', $(this).attr('id').replace('_0_', '_' + (parseInt(index) + 1) + '_'));
        if ($(this).attr('for') != null)
            $(this).attr('for', $(this).attr('for').replace('_0_', '_' + (parseInt(index) + 1) + '_'));
        if ($(this).attr('data-valmsg-for') != null)
            $(this).attr('data-valmsg-for', $(this).attr('data-valmsg-for').replace('\[0\]', '\[' + (parseInt(index) + 1) + '\]'));
        if ($(this).attr('onclick') != null)
            $(this).attr('onclick', $(this).attr('onClick').replace('0', (parseInt(index) + 1)));
    });
}

/**
 * 
 * @param {} event 
 * @param {} index 
 * @param {} selector 
 * @returns {} 
 */
var deleteTag = function (index, selector) {
    //event.preventDefault();
    if (index != 0)
        $(selector).remove("[data-index='" + index + "']");
}

/**
 * 
 * @param {} elem 
 * @returns {} 
 */
var removeConfirm = function (elem) {
    messageConfirmDialog("آیا برای حذف اطمینان دارید؟", true, function () { removeItem(elem); });
}

/**
 * 
 * @param {} elem 
 * @returns {} 
 */
var navigate = function (elem) {
    var key = $(elem).attr('name');
    var value = $(elem).val();

    setQuryStringParameter(key, value);
}

/**
 * 
 * @param {} e 
 * @param {} elem 
 * @returns {} 
 */
var searchGrid = function (e, elem) {
    var key = $(elem).attr('name');
    var value = $(elem).val();

    e = e || window.event;
    if (e.keyCode === 13) {
        setQuryStringParameter(key, value);
        return false;
    }
    return true;
}

/**
 * 
 * @returns {} 
 */
var startUp = function () {
    navMove();
    goUp();
}

/**
 * 
 * @param {} elem 
 * @returns {} 
 */
var openShadow = function (elem) {
    var shadowType = $(elem).data('type');
    switch (shadowType) {
        case "gallery":
            openSlideLoader(elem);
            break;

        case "modal":
            openItemModal(elem);
            break;
    }
}

/**
 * 
 * @param {} elem 
 * @returns {} 
 */
var rightGalleryFiles = function (elem) {
    rightSlideButton(elem);
}

/**
 * 
 * @param {} elem 
 * @returns {} 
 */
var leftGalleryFiles = function (elem) {
    leftSlideButton(elem);
}

/**
 * 
 * @param {} elem 
 * @returns {} 
 */
var closeShadow = function (elem) {
    closeSlideButton(elem);
}

var loadSliderCircle = function () {
    setInterval(timingSliderCircle, 5000);
}

var timingSliderCircle = function () {
    selectSlideImage('unset');
}

selectSlideImage = function (elem) {
    if (elem === 'unset') {
        var circleVirtualElem = $('.landing-slide-circles').children('.fa-circle');
        var circleVirtualId = $(circleVirtualElem).attr('id');
        switch (circleVirtualId) {
            case 'Circle1':
                var circleId = 'Circle2';
                break;
            case 'Circle2':
                var circleId = 'Circle3';
                break;
            case 'Circle3':
                var circleId = 'Circle1';
                break;
        }
        var circleElem = $('.landing-slide-circles').children('#' + circleId);
    }
    else {
        var circleElem = elem;
        var circleId = $(circleElem).attr('id');
    }
    $(circleElem).parent().children('.fa-circle').attr('class', 'fa fa-circle-thin');
    $(circleElem).attr('class', 'fa fa-circle');
    $('.landing-slider').children('a').children('img').hide();
    switch (circleId) {
        case 'Circle1':
            $('#Slide1').show();
            break;
        case 'Circle2':
            $('#Slide2').show();
            break;
        case 'Circle3':
            $('#Slide3').show();
            break;
    }
}


var calcPlanInvoice = function (elem) {
    var price = $(elem).parent().children('.plan-pre-price').text();
    var finalPrice = $(elem).parent().children('.plan-price').text();
    var intPrice = parseInt(price.split(" ", 1));
    var intFinalPrice = parseInt(finalPrice.split(" ", 1));
    var discountPrice = intPrice - intFinalPrice;
    var discountPercent = $(elem).parent().children('.plan-discount-tag').text();
    var planSelector = $(elem).parents('.outer-month').children('.plan-order-radio').val();
    switch (planSelector) {
        case 'Bronze12':
            var plan = $('#planFundamental').text();
            var duration = $('#durationOneYear').text();
            break;
        case 'Silver6':
            var plan = $('#planEconomical').text();
            var duration = $('#durationSixMonths').text();
            break;
        case 'Silver12':
            var plan = $('#planEconomical').text();
            var duration = $('#durationOneYear').text();
            break;
        case 'Golden6':
            var plan = $('#planSpecial').text();
            var duration = $('#durationSixMonths').text();
            break;
        case 'Golden9':
            var plan = $('#planSpecial').text();
            var duration = $('#durationNineMonths').text();
            break;
        case 'Golden12':
            var plan = $('#planSpecial').text();
            var duration = $('#durationOneYear').text();
            break;
    }
    $('#PlanTitle').text('').append(plan);
    $('#PlanValidity').text('').append(duration);
    $('#PlanPrice').text('').append(price);
    $('#PlanDiscountPercent').text('').append(discountPercent);
    $('#PlanDiscountPrice').text('').append(discountPrice + ",000");
    $('#PlanFinalPrice').text('').append(finalPrice);
}


var landingCarousel = function () {
    var landingCarouselOptions = {
        nav: true,
        navText: ["<i class='fa fa-chevron-left'></i>", "<i class='fa fa-chevron-right'></i>"],
        responsiveClass: true,
        responsive: {
            0: {
                items: 1
            },
            407: {
                items: 2
            },
            603: {
                items: 3
            },
            797: {
                items: 4
            },
            873: {
                items: 3
            },
            1097: {
                items: 4
            },
            1291: {
                items: 5
            }
        }
    }
    $(".owl-carousel").owlCarousel(landingCarouselOptions);
}


var mainMenuExpand = function (elem) {
    var expand = $(elem).parent(".main-menu-categories").children(".sub-cat-expand");
    expand.hide();
    var h = $(".main-menu-categories").css("height");
    $(elem).parent(".main-menu-categories").css("height", h);
    expand.css("height", h);
    var currentExpand = $(elem).next(0);
    var subListCount = $(currentExpand).children().children("li").length;
    var corners;
    var expandWidth = -200;
    if (subListCount !== 0) {
        corners = "0 5px 5px 0";
        currentExpand.css("display", "block");
        var sumHeight = 0;
        var columnCount = 1;
        for (var i = 0; i < subListCount; ++i) {
            var subCategoryBox = $(currentExpand).children().children("li")[i];
            var strBoxHeight = $(subCategoryBox).css("height");
            var boxHeight = parseInt(strBoxHeight.split("px"));
            var columnHeight = sumHeight + boxHeight;
            if (columnHeight > parseInt(h.split("px"))) {
                sumHeight = boxHeight;
                columnCount += 1;
            } else {
                sumHeight = columnHeight;
            }
            expandWidth = (columnCount - 1) * 200;
            $(subCategoryBox).css("right", expandWidth);
            $(subCategoryBox).css("top", (sumHeight - boxHeight));
        }
        $(currentExpand).css("width", (columnCount * 200));
    } else {
        corners = "5px";
    }
    expand.css("width", (expandWidth + 200));
    changeBorderRadius(corners);
}


var changeBorderRadius = function (borderRadius) {
    $(".main-menu-categories").css("border-radius", borderRadius);
    $(".main-menu-categories").css("-webkit-border-radius", borderRadius);
    $(".main-menu-categories").css("-moz-border-radius", borderRadius);
    $(".main-menu-categories").css("-o-border-radius", borderRadius);
    $(".main-menu-categories").css("-ms-border-radius", borderRadius);
    $(".main-menu-categories").css("-khtml-border-radius", borderRadius);
}


var mainMenuCollapse = function (elem) {
    $(elem).children("ul").children(".sub-cat-expand").hide();
    $(elem).children("ul").children(".sub-cat-expand").css("width", "0");
}


var listSearchbarFilterToggle = function(elem) {
    $(elem).parent().parent().toggleClass("filter-toggle");
}




/**
 *
 * @returns {}
 */
var positionCompanyMenu = function (elem) {
    var menuTop = $(elem)[0].getBoundingClientRect().top + $(window)['scrollTop']() - 66;
    var footerTop = $("footer")[0].getBoundingClientRect().top + $(window)['scrollTop']();
    var h = $(elem).height();
    var footerTopScroll = footerTop - h - 76;
    $(window).scroll(function () {
        if (($(this).scrollTop() > menuTop) && ($(this).scrollTop() > footerTopScroll)) {
            $(elem).removeClass("fixedMenu");
            $(elem).addClass("fixedMenuFooter");
            $(elem).css("bottom", ($(window).height() - $("footer")[0].getBoundingClientRect().top + 20));
        } else if ($(this).scrollTop() > (menuTop)) {
            $(elem).removeClass("fixedMenuFooter");
            $(elem).addClass("fixedMenu");
            $(elem).css("bottom", "");
        } else {
            $(elem).removeClass("fixedMenuFooter");
            $(elem).removeClass("fixedMenu");
        }
    });
};


var companyTabTransition = function (elem) {
    var sectionId = "#" + $(elem).data("section");
    var sectionH = $(sectionId)[0].getBoundingClientRect().top + $(window)['scrollTop']();
    $('body,html').animate({ scrollTop: (sectionH - 50) }, 400);
}