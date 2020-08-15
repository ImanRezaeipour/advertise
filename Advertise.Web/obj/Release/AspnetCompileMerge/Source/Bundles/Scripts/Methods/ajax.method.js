/**
 * 
 * @param {} elem 
 * @returns {} 
 */
var loadMore = function (elem) {
    var param = $(elem).data('param');

    $.ajax({
        url: window.appCultureRoute + '/' + param,
        data: $("#search").serialize(),
        type: 'GET',
        dataType: 'json',
        complete: function (xhr, status) {

        }
    });
}

/**
 * 
 * @param {} elem 
 * @returns {} 
 */
var removeItem = function (elem) {
    debugger;
    var id = $(elem).data('param-id');
    var param = $(elem).data('param');

    $.ajax({
        url: window.appCultureRoute + '/' + param + '/deleteajax',
        data: { id: id },
        type: 'POST',
        dataType: 'json',
        complete: function (xhr, status) {
            console.log(xhr.status);
            if (status === 403) {
                messageError('عدم دسترسی');
            }
            if (xhr.status === 200) {
                messageSuccess('حذف با موفقیت انجام شد');
                window.location.reload();
            } else {
                messageError('خطایی رخ داده است');
            }
        }
    });
}

var checkValidatorAliasUser = function (elem) {
    var alias = $('#UserName').val();

    $.ajax({
        url: window.appCultureRoute + '/user/AliasRemoteValidatorAjax',
        data: { alias: alias },
        type: 'POST',
        dataType: 'json',
        complete: function (xhr, status) {
            var valueUserName;
            console.log(xhr);
            if (xhr.responseText !== "") {
                $('#UserName').css('background-color','#ff0000');
                $('#UserName').val('');
                  $('#UserName').val(function () {
                    return this.value +  'لطفا نام کاربری دیگری انتخاب کنید';
               });
            }
        }
    });
}

/**
 * 
 * @param {} tag 
 * @returns {} 
 */
var toggleLike = function(tag) {
    debugger;
    var toggleUrl = $(tag).data('toggle-url');
    var container = $(tag).data('container');
    var count = $(tag).data('count-url');
    var id = $(tag).data('id');

    $.ajax({
        url: toggleUrl,
        data: { id: id },
        type: "POST",
        dataType: "json",
        success: function (data) {
            $(tag).toggleClass("fa-heart-o fa-heart");
            $.ajax({
                url: count,
                data: { id: id },
                type: "POST",
                dataType: "json",
                success: function (data) {
                    $(container).text(data);
                }
            });
        }
    });
}

/**
 *
 * @returns {}
 */
var loadProductSpecification = function () {
    var id = $('#CategoryId').val();

    $.ajax({
        url: window.appCultureRoute + '/ProductSpecification/createajax',
        data: { categoryId: id },
        type: 'GET',
        dataType: 'json',

        complete: function (xhr, status) {
            console.log(xhr);
            if (xhr.status === 500) {
                $('#specificationContainer').empty();
                $('#specificationContainer').append(xhr.responseText);
            }
            else {
                $('#specificationContainer').empty();
                $('#specificationContainer').append(xhr.responseJSON);
            }
        }
    });
}

/**
 *
 * @param {} elem
 * @returns {}
 */
var loadEditProductSpecification = function (elem) {
    var id = $('#Id').val();

    $.ajax({
        url: window.appCultureRoute + '/ProductSpecification/EditAjax',
        data: { productId: id },
        type: 'GET',
        dataType: 'json',
        complete: function (xhr, status) {
            console.log(xhr);
            if (xhr.status === 500) {
                $('#specificationContainer').empty();
                $('#specificationContainer').append(xhr.responseText);
            }
            else {
                $('#specificationContainer').empty();
                $('#specificationContainer').append(xhr.responseJSON);
            }
        }
    });
}

/**
 * با توجه به مقادیر موجود متد فراخوانی لیست های محصولات را اجرا میکند
 * @param {} elem
 * @returns {}
 */
var fillSearchProducts = function (elem) {
    var categoryId = getUrlParameterByName('c');
    if (categoryId === null || categoryId === '') {
        categoryId = $('#categoryId').val();
    }
    else {
        $('#categoryId').val(categoryId);
        $("#category").val(categoryId);
    }

    var term = getUrlParameterByName('t');
    if (term === null || term === '') {
        term = $('#term').val();
    }
    else {
        $('#term').val(term);
        $('#searchProduct').val(term);
    }

    var stateId = getUrlParameterByName('s');
    if (stateId === null || stateId === '') {
        stateId = $('#stateId').val();
    }
    else {
        $('#stateId').val(stateId);
        $('#city').val(stateId);
    }

    var pageSize = getUrlParameterByName('ps');
    if (pageSize === null || pageSize === '') {
        pageSize = $('#pageSize').val();
    }
    else {
        $('#pageSize').val(pageSize);
        $('#pageSizeFilter').val(pageSize);
    }

    var sortMember = getUrlParameterByName('m');
    if (sortMember === null || sortMember === '') {
        sortMember = $('#sortMember').val();
    }
    else {
        $('#sortMember').val(sortMember);
        $('#sortMemberFilter').val(sortMember);
    }

    var sortDirection = getUrlParameterByName('d');
    if (sortDirection === null || sortDirection === '') {
        sortDirection = $('#sortDirection').val();
    }
    else {
        $('#sortDirection').val(sortDirection);
        $('#sortDirectionFilter').val(sortDirection);
    }

    var totalCount = $('#total').val();
    var totalPage = parseInt((totalCount / pageSize) + 1);

    var page = getUrlParameterByName('p');
    if (page === null || page === '') {
        page = $('#page').val();
    }
    else {
        $('#page').val(page);
    }

    $.ajax({
        url: window.appCultureRoute + '/product/ListMoreAjax',
        data: { CategoryWithMany: 'true', sortDirection: sortDirection, sortMember: sortMember, pageSize: pageSize, page: page, term: term, categoryId: categoryId, stateId: stateId },
        type: 'GET',
        dataType: 'json',
        complete: function (xhr, status) {
            $('#searchProductContainer').empty();
            $('#searchProductContainer').append(xhr.responseJSON.Data);
            $('#searchProductContainer').children().addClass('detail-column');
            $('#searchProductContainer').children().wrap("<div class='detail-items'></div>");
            $('#searchProductContainer').children().wrapAll("<div class='detail-column-wrapper'></div>");
            onLoadNavigator();
            $(".tooltipster").each(function () {
                simpleTooltip(this);
            });
            //onAjaxLoadNavigator();
        }
    });

    $.ajax({
        url: window.appCultureRoute + '/product/GetCountAjax',
        data: { CategoryWithMany: 'true', sortDirection: sortDirection, sortMember: sortMember, pageSize: pageSize, page: page, term: term, categoryId: categoryId, stateId: stateId },
        type: 'GET',
        dataType: 'json',
        complete: function (xhr, status) {
            $('#total').val(xhr.responseText);
            $('#totalCount').empty();
            $('#totalCount').append('مجموع محصولات: ' + xhr.responseText);

            productSearchPagination();
        }
    });
}

/**
 * انتخابگر دسته
 * @param {} elem
 * @returns {}
 */
var selectCategory = function (elem) {
    var selectedId = $(elem).find(':selected').val();
    if (selectedId === '-1') {
        $('#subCategoryContainer').hide();
        $('#categoryId').val('');
        window.history.pushState(null, null, setUrlEncodedKey("c", ''));
        fillSearchProducts();
    }
    else {
        $('#categoryId').val(selectedId);
        window.history.pushState(null, null, setUrlEncodedKey("c", selectedId));
        var id = $('#categoryId').val();
        $.ajax({
            url: window.appCultureRoute + '/category/GetCategoriesAjax',
            data: { id: id },
            type: 'GET',
            dataType: 'json',
            complete: function (xhr, status) {
                $('#subCategory').empty();

                $('#subCategoryContainer').hide();

                $.each(xhr.responseJSON.Data,
                    function (key, value) {
                        $('#subCategory').append('<li value="' + value.Id + '" class="dropdown-item"><a href="javascript:void(0);" data-action="selectSubCategory" data-event="click">' + value.Title + '</a></li>');
                    });

                if ($('#subCategory').children().length > 0) {
                    $('#subCategoryContainer').removeClass('hide-none');
                    $('#subCategoryContainer').show();
                }

                fillSearchProducts();
            }
        });
    }
}

/**
 *
 * @param {} elem
 * @returns {}
 */
var bagDelete = function (elem) {
    var id = $(elem).data('param');
    $(elem).prop('disabled', true);
    $.ajax({
        url: window.appCultureRoute + "/bag/delete",
        data: { productId: id },
        type: 'POST',
        dataType: 'json',
        complete: function (xhr, status) {
            if (xhr.responseText == 1) {
                $("[data-param=" + id + "][data-state='buy']").parent().css('margin-top', '0');
                loadBagCount($("#HeaderCartCounter"));
            }
        }
    });
    $(elem).prop('disabled', false);
}

/**
 *
 * @param {} elem
 * @returns {}
 */
var bagCreate = function (elem) {
    var id = $(elem).data('param');
    $(elem).prop('disabled', true);
    $.ajax({
        url: window.appCultureRoute + "/bag/create",
        data: { productId: id },
        type: 'POST',
        dataType: 'json',
        complete: function (xhr, status) {
            if (xhr.responseText == 1) {
                $("[data-param=" + id + "][data-state='unbuy']").parent().css('margin-top', '-42px');
                loadBagCount($("#HeaderCartCounter"));

            }
        }
    });

    $(elem).prop('disabled', false);
}

/**
 *
 * @param {} tag
 * @returns {}
 */
var toggleLikeProduct = function(elem) {
    var id = $("#productId").val();
    var count = parseInt($(elem).children('span').text());
    var isLiked = $(elem).children('i').hasClass('fa-heart');

    $.ajax({
        url: window.appCultureRoute + "/ProductLike/MyToggleLikeAjax",
        data: { productId: id },
        type: "POST",
        dataType: "json",
        success: function(data) {
            if (data.Success) {
                $(elem).children('i').toggleClass('fa-heart fa-heart-o');
                if (isLiked === true) {
                    var minusCount = String(count - 1);
                    $(elem).children('span').text(minusCount);
                } else {
                    var plusCount = String(count + 1);
                    $(elem).children('span').text(plusCount);
                }
            }
        }
    });
}

/**
 *
 * @param {} elem
 * @returns {}
 */
var toggleFollowCompany = function(elem) {
    var id = $(elem).parent(".follow-button-wrapper").children("#Id").val();
    var count = parseInt($('#FollowerCount').text());
    var isFollowed = $(elem).hasClass('followed-btn');
    var follow = $(elem).attr('data-follow');
    var unfollow = $(elem).attr('data-unfollow');
    $.ajax({
        url: window.appCultureRoute + "/companyfollow/MyToggleFollowAjax",
        data: { companyId: id },
        type: "POST",
        dataType: "json",
        success: function(data) {
            if (data.Success) {
                $(elem).removeClass('followed-btn');
                $(elem).removeClass('unfollowed-btn');
                if (isFollowed === true) {
                    $(elem).addClass('unfollowed-btn');
                    $(elem).text('');
                    $(elem).text(follow);
                    var minusCount = String(count - 1);
                    $('#FollowerCount').text('');
                    $('#FollowerCount').text(minusCount);
                } else {
                    $(elem).addClass('followed-btn');
                    $(elem).text('');
                    $(elem).text(unfollow);
                    var plusCount = String(count + 1);
                    $('#FollowerCount').text('');
                    $('#FollowerCount').text(plusCount);
                }
            }
        }
    });
}

/**
 *
 * @param {} elem
 * @returns {}
 */
var loadCategories = function(elem) {
    $.ajax({
        url: window.appCultureRoute + '/category/GetCategoriesAjax',
        data: {},
        type: 'GET',
        dataType: 'json',
        complete: function(xhr, status) {
            $.each(xhr.responseJSON.Data,
                function(key, value) {
                    $(elem).append('<option value="' + value.Id + '">' + value.Title + '</option>');
                });
        }
    });
}

var toggleLike = function(tag) {
    var toggleUrl = $(tag).data('toggle-url');
    var container = $(tag).data('container');
    var count = $(tag).data('count-url');
    var id = $(tag).data('id');

    $.ajax({
        url: toggleUrl,
        data: { id: id },
        type: "POST",
        dataType: "json",
        success: function(data) {
            $(tag).toggleClass("fa-heart-o fa-heart");

            $.ajax({
                url: count,
                data: { id: id },
                type: "POST",
                dataType: "json",
                success: function(data) {
                    $(container).text(data);
                }
            });
        }
    });
}

/**
 *
 * @param {} elem
 * @returns {}
 */
var selectCity = function (elem) {
    var id = $('#ProvinceId').val();

    $.ajax({
        url: window.appCultureRoute + '/Address/GetCityAjax',
        data: { id: id },
        type: 'GET',
        dataType: 'json',

        success: function (data) {
            console.log(data);
            $('#Address_City_Id').empty();
            $.each(data, function (key, value) {
                $('#Address_City_Id').append('<option value="' + value.Value + '">' + value.Text + '</option>');
            });

            var cityId = $('#CityId').val();
            $('#Address_City_Id').val(cityId);
        }
    });
}

/**
 *
 * @param {} elem
 * @returns {}
 */
var selectProvince = function (elem) {
    var id = $(elem).find(':selected').val();

    $.ajax({
        url: window.appCultureRoute + '/Address/GetCityAjax',
        data: { id: id },
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            $('#Address_City_Id').empty();
            $('#Address_City_Id').append('<option value="" selected disabled>-- انتخاب کنید --</option>');
            $.each(data, function (key, value) {
                $('#Address_City_Id').append('<option value="' + data[key].Value + '">' + data[key].Text + '</option>');
            });
        }
    });
}

/**
 *
 * @param {} elem
 * @returns {}
 */
var sendProductComment = function (elem) {
    $('#btnSendComment').prop("disabled", true);
    var productId = $('#Id').val();
    var body = $('#commentBody').val();

    $.ajax({
        url: window.appCultureRoute + '/ProductComment/CreateAjax',
        data: { productId: productId, body: body },
        type: 'GET',
        dataType: 'json',
        complete: function (xhr, status) {
            if (xhr.responseJSON === 0) {
                messageError('متاسفانه خطایی رخ داده است مجدد تلاش کنید');
                $('#btnSendComment').prop("disabled", false);
            } else if (xhr.responseJSON === 1) {
                messageSuccess('دیدگاه شما با موفقیت ثبت گردید');
                $('#commentBody').val('');
                $('#btnSendComment').prop("disabled", false);
            } else {
                messageError('متاسفانه خطایی رخ داده است مجدد تلاش کنید');
                $('#btnSendComment').prop("disabled", false);
            }
        }
    });
}

var sendConversation = function (elem) {
    var receivedById = $('#CreatedById').val();
    var body = $('#commentBody').val();
  
    $.ajax({
        url: window.appCultureRoute + '/CompanyConversation/CreateAjax',
        data: { receivedById: receivedById, body: body},
        type: 'GET',
        dataType: 'json',
        complete : function(xhr, status) {
            if (xhr.responseJSON === 0) {
                messageError('متاسفانه خطایی رخ داده است مجدد تلاش کنید');
            } else if (xhr.responseJSON === 1) {
                messageSuccess('دیدگاه شما با موفقیت ثبت گردید');
                $('#commentBody').val('');
            } else  {
                messageError('متاسفانه خطایی رخ داده است مجدد تلاش کنید');
            }
        }
    });
}


var selectListConversation = function (elem) {
    var createdById = $('#CreatedById').val();
    $.ajax({
        url: window.appCultureRoute + '/CompanyConversation/detailAjax',
        data: { createdById: createdById },
        type: 'GET',
        dataType: 'json',
        complete: function (xhr, status) {
            console.log(xhr);
            $('#container').html(xhr.responseJSON);

            $("#btnSendConversation").unbind('click').click(function () {
                sendConversation(this);
            });

        }
    });
}


var sendQA = function (elem) {
    debugger;

    var receivedById = $('#CreatedById').val();
    var body = $('#commentBody').val();
    var replyId = $('#ReplyId').val();
    if (replyId !== null) {
        $('#commentBodyReply').removeAttr('hidden');
        body = $('#commentBodyReply').val();
    }
    $.ajax({
        url: window.appCultureRoute + '/CompanyConversation/CreateAjax',
        data: { receivedById: receivedById, body: body, replyId: replyId },
        type: 'GET',
        dataType: 'json',
        complete: function (xhr, status) {
            if (xhr.responseJSON === 0) {
                messageError('متاسفانه خطایی رخ داده است مجدد تلاش کنید');
            } else if (xhr.responseJSON === 1) {
                messageSuccess('دیدگاه شما با موفقیت ثبت گردید');
                $('#commentBody').val('');
            } else {
                messageError('متاسفانه خطایی رخ داده است مجدد تلاش کنید');
            }
        }
    });
}

/**
 * 
 * @param {} elem 
 * @returns {} 
 */
var subscribe = function (elem) {
    var email = $('#Email').val();
    $.ajax({
        url: window.appCultureRoute + "/newsletter/SubscribeAjax",
        dataType: "json",
        data: { Email: email },
        type: "POST",
        complete: function (xhr, status) {
        }
    });
}

/**
 *
 * @param {} elem
 * @returns {}
 */
var toggleFollowCategory = function(elem) {
    var id = $(elem).parent(".follow-button-wrapper").children("#categoryId").val();
    var count = parseInt($('#FollowerCount').text());
    var isFollowed = $(elem).hasClass('followed-btn');
    var follow = $(elem).attr('data-follow');
    var unfollow = $(elem).attr('data-unfollow');
    $.ajax({
        url: window.appCultureRoute + "/categoryfollow/MyToggleFollowAjax",
        data: { categoryId: id },
        type: "POST",
        dataType: "json",
        success: function(data) {
            if (data.Success) {
                $(elem).removeClass('followed-btn');
                $(elem).removeClass('unfollowed-btn');
                if (isFollowed === true) {
                    $(elem).addClass('unfollowed-btn');
                    $(elem).text('');
                    $(elem).text(follow);
                    var minusCount = String(count - 1);
                    $('#FollowerCount').text('');
                    $('#FollowerCount').text(minusCount);
                } else {
                    $(elem).addClass('followed-btn');
                    $(elem).text('');
                    $(elem).text(unfollow);
                    var plusCount = String(count + 1);
                    $('#FollowerCount').text('');
                    $('#FollowerCount').text(plusCount);
                }
            }
        }
    });
}

/**
 *
 * @param {} elem
 * @returns {}
 */
var bagChangeProductCount = function (elem) {
    $(elem).prop("disabled", true);
    var id = $(elem).data('param');
    var price = $(elem).data('param-2');
    var count = $(elem).val();

    $.ajax({
        url: window.appCultureRoute+"/bag/ChangeProductCount",
        data: {
            productId: id,
            productCount: count
        },
        dataType: 'json',
        type: 'POST',
        complete: function (xhr, status) {
            if (xhr.responseText == 1) {
                $(elem).val(count);
                productTotal = price * count;
                $(elem).closest('.removable-bag-item').children('.purchase-item-recommend').children('.price').text('');
                $(elem).closest('.removable-bag-item').children('.purchase-item-recommend').children('.price').append(productTotal);
                $(elem).closest('.removable-bag-item').children('.purchase-item-recommend').children('.price').attr('data-val', productTotal);
                var total = findTotalBagPrice('.total-product-price');
                $('.total-bag-price').text('');
                $('.total-bag-price').append(total);
                $(elem).prop('disabled', false);
            }
        }
    });
}

/**
 *
 * @param {} elem
 * @returns {}
 */
var bagProfileDelete = function (elem) {
    var id = $(elem).data('param');
    $(elem).prop('disabled', true);
    $.ajax({
        url: window.appCultureRoute + "/bag/delete",
        data: { productId: id },
        type: 'POST',
        dataType: 'json',
        complete: function (xhr, status) {
            if (xhr.responseText == 1) {
                $(elem).parent().remove();
                //$("#PurchasesListHeader").hide();
                //$("#BagTotalListWrapper").hide();
                //$("#BagFooter").hide();
                $("#PageLoader").append('<i class="fa fa-spinner fa-pulse fa-3x"></i>');
                $("#PageLoader").show();
                $("#BagShadow").show();
                var total = findTotalBagPrice('.total-product-price');
                $('.total-bag-price').text('');
                $('.total-bag-price').append(total);
                location.reload();
            }
            $(elem).prop('disabled', false);
        }
    });
}

/**
 * 
 * @param {} elem 
 * @returns {} 
 */
var getBusinessInformations = function (elem) {
    var subDomain = $(elem).data('param');
    $.ajax({
        url: window.appCultureRoute + '/company/DetailAjax',
        data: { id: subDomain },
        type: 'GET',
        dataType: 'json',
        complete: function (xhr, status) {
            console.log(xhr.responeText);
            $('#PhoneNumber').text('').removeClass('first-load-info').append(xhr.responseJSON.PhoneNumber);
            $('#MobileNumber').text('').removeClass('first-load-info').append(xhr.responseJSON.MobileNumber);
            $('#EmailAddress').text('').removeClass('first-load-info').append(xhr.responseJSON.Email);
            $('#AddressPlace').text('').removeClass('first-load-info').append(xhr.responseJSON.Address);
            $('#WebsiteAddress').text('').removeClass('first-load-info').append(xhr.responseJSON.WebSite);
        }
    });
}

/**
 * 
 * @param {} elem 
 * @returns {} 
 */
var getUserInformations = function (elem) {
    var userName = $(elem).data('param');
    $.ajax({
        url: window.appCultureRoute + '/user/DetailAjax',
        data: { id: userName },
        type: 'GET',
        dataType: 'json',
        complete: function (xhr, status) {
            $('#HomeNumber').text('').removeClass('first-load-info').append(xhr.responseJSON.HomeNumber);
            $('#PhoneNumber').text('').removeClass('first-load-info').append(xhr.responseJSON.PhoneNumber);
            $('#EmailAddress').text('').removeClass('first-load-info').append(xhr.responseJSON.Email);
            $('#AddressPlace').text('').removeClass('first-load-info').append(xhr.responseJSON.Address.Extra);
            $('#WebsiteAddress').text('').removeClass('first-load-info').append(xhr.responseJSON.Website);
        }
    });
}