/**
 * 
 * @returns {} 
 */
var onLoadNavigator = function () {
    $("[data-action]").each(function () {
        var action = $(this).data("action");
        var actionEvent = $(this).data("event");
        var actionParam = $(this).data("param");

        switch (actionEvent) {
            case "load":
                $(this).data("event", "loaded");

                switch (action) {
                    case "treeCategory":
                        treeCategory(this, (actionParam === "edit"));
                        break;

                    case "treeRole":
                        treeRole(this, (actionParam === "edit"));
                        break;

                    case "treeCategoryProduct":
                        treeCategoryProduct(this, (actionParam === "edit"));
                        break;
                    case "treeCategoryReview":
                        treeCategoryReview(this, (actionParam === "edit"));
                        break;
                    case "treeCategorySpecification":
                        treeCategorySpecification(this, (actionParam === "edit"));
                        break;
                    case "treeCategorySpecificationOption":
                        treeCategorySpecificationOption(this, (actionParam === "edit"));
                        break;
                    case "treeCategoryCompany":
                        treeCategoryCompany(this, (actionParam === "edit"));
                        break;

                    case "uploaderCompanyImage":
                        uploaderCompanyImage(this, (actionParam === "edit"));
                        break;
                    case "uploaderCompanyAttachment":
                        uploaderCompanyAttachment(this, (actionParam === "edit"));
                        break;

                    case "uploaderCategory":
                        uploaderCategory(this, (actionParam === "edit"));
                        break;

                    case "uploaderCompany":
                        uploaderCompany(this, (actionParam === "edit"));
                        break;

                    case "uploaderCompanyCover":
                        uploaderCompanyCover(this, (actionParam === "edit"));
                        break;

                    case "uploaderProductImages":
                        uploaderProductImages(this, (actionParam === "edit"));
                        break;

                    case "uploaderProductImage":
                        uploaderProductImage(this, (actionParam === "edit"));
                        break;

                    case "uploaderTag":
                        uploaderTag(this, (actionParam === "edit"));
                        break;

                    case "uploaderUser":
                        uploaderUser(this, (actionParam === "edit"));
                        break;

                    case "editorCompanyReview":
                        editorCompanyReview(this);
                        break;

                    case "fillSearchProducts":
                        fillSearchProducts(this);
                        break;

                    case "loadCategory":
                        loadCategory(this);
                        break;

                    case "loadCity":
                        loadCity(this);
                        break;

                    case "loadCategories":
                        loadCategories(this);
                        break;

                    case "loadEditProductSpecification":
                        loadEditProductSpecification(this);
                        break;

                    case "selectCity":
                        selectCity(this);
                        break;

                    case "slideSize":
                        slideSize();
                        break;

                    case "loadViewType":
                        loadViewType(this);
                        break;

                    case "loadBusinessInfos":
                        getBusinessInformations(this);
                        break;

                    case "loadUserInfos":
                        getUserInformations(this);
                        break;

                        //case "uploaderCompanyVideo":
                        //    uploaderCompanyVideo(this);
                        //    break;

                    case "loadSliderCircle":
                        loadSliderCircle();
                        break;

                    case "loadLandingCarousel":
                        landingCarousel();
                        break;

                    case "companyMenuPosition":
                        positionCompanyMenu(this);
                        break;

                        //case "uploaderCompanyAttachment":
                        //    uploaderCompanyAttachment(this);
                        //    break;
                }
                break;

            case "click":
                $(this).data('event', 'clicked');
                $(this).unbind('click');

                switch (action) {
                    case "removeItem":
                        $(this).click(function () {
                            removeConfirm(this);
                        });
                        break;

                    case "toggleFollowCompany":
                        $(this).click(function () {
                            toggleFollowCompany(this);
                        });
                        break;

                    case "subscribe":
                        $(this).click(function () {
                            subscribe(this);
                        });
                        break;

                    case "toggleFollowCategory":
                        $(this).click(function () {
                            toggleFollowCategory(this);
                        });
                        break;

                    case "toggleLikeProduct":
                        $(this).click(function () {
                            toggleLikeProduct(this);
                        });
                        break;

                    case "navigate":
                        $(this).click(function () {
                            onLoadNavigator();
                        });
                        break;

                    case "addFeatures":
                        $(this).click(function () {
                            addFeatures(this);
                        });
                        break;

                    case "removeFeatures":
                        $(this).click(function () {
                            removeFeatures(this);
                        });
                        break;

                    case "addSpecificationoption":
                        $(this).click(function () {
                            addSpecificationoption(this);
                        });
                        break;

                    case "removeSpecificationoption":
                        $(this).click(function () {
                            removeSpecificationoption(this);
                        });
                        break;

                    case "bagCreate":
                        $(this).click(function () {
                            bagCreate(this);
                        });
                        break;

                    case "bagDelete":
                        $(this).click(function () {
                            bagDelete(this);
                        });
                        break;

                    case "bagProfileDelete":
                        $(this).click(function () {
                            bagProfileDelete(this);
                        });
                        break;

                    case "selectSubCategory":
                        $(this).click(function () {
                            selectSubCategory(this);
                        });
                        break;

                    case "selectPageFilter":
                        $(this).click(function () {
                            selectPageFilter(this);
                        });
                        break;

                    case "searchOnLanding":
                        $(this).click(function () {
                            searchOnLanding(this);
                        });
                        break;

                    case "sendProductComment":
                        $(this).click(function () {
                            sendProductComment(this);
                        });
                        break;
                    case "sendConversation":
                        $(this).click(function () {
                            sendConversation(this);
                        });
                        break;

                    case "refreshCaptcha":
                        $(this).click(function () {
                            refreshCaptcha(event, this);
                        });
                        break;

                    case "openModal":
                        $(this).click(function () {
                            openModal(this);
                        });
                        break;

                    case "closeModal":
                        $(this).click(function () {
                            closeModal(this);
                        });
                        break;

                    case "showCompanyTab":
                        $(this).click(function () {
                            showCompanyTab(this);
                        });
                        break;

                    case "nextSlideImg":
                        $(this).click(function () {
                            nextSlideImg();
                        });
                        break;

                    case "prevSlideImg":
                        $(this).click(function () {
                            prevSlideImg();
                        });
                        break;

                    case "resizeSlide":
                        $(this).click(function () {
                            resizeSlide(this);
                        });
                        break;

                    case "renderView":
                        $(this).click(function () {
                            renderView(this);
                        });
                        break;

                    case "openShadow":
                        $(this).click(function () {
                            openShadow(this);
                        });
                        break;

                    case "rightGalleryFiles":
                        $(this).click(function () {
                            rightGalleryFiles(this);
                        });
                        break;

                    case "leftGalleryFiles":
                        $(this).click(function () {
                            leftGalleryFiles(this);
                        });
                        break;

                    case "closeShadow":
                        $(this).click(function () {
                            closeShadow(this);
                        });
                        break;

                    case "sliderCircle":
                        $(this).click(function () {
                            selectSlideImage(this);
                        });
                        break;

                    case "calcPlanInvoice":
                        $(this).click(function () {
                            calcPlanInvoice(this);
                        });
                        break;

                    case "companyTabTransition":
                        $(this).click(function () {
                            companyTabTransition(this);
                        });
                        break;
                }
                break;

            case "change":
                $(this).data('event', 'changed');
                $(this).unbind('change');

                switch (action) {
                    case "navigate":
                        $(this).change(function () {
                            navigate(this);
                        });
                        break;

                    case "bagChangeProductCount":
                        $(this).change(function () {
                            bagChangeProductCount(this);
                        });
                        break;

                    case "selectProvince":
                        $(this).change(function () {
                            selectProvince(this);
                        });
                        break;
                    case "selectListConversation":
                        $(this).change(function () {
                            selectListConversation(this);
                        });
                        break;

                    case "selectSortMemberFilter":
                        $(this).change(function () {
                            selectSortMemberFilter(this);
                        });
                        break;

                    case "selectSortDirectionFilter":
                        $(this).change(function () {
                            selectSortDirectionFilter(this);
                        });
                        break;

                    case "selectPageSizeFilter":
                        $(this).change(function () {
                            selectPageSizeFilter(this);
                        });
                        break;

                    case "selectCategory":
                        $(this).change(function () {
                            selectCategory(this);
                        });
                        break;

                    case "selectSearchCity":
                        $(this).change(function () {
                            selectSearchCity(this);
                        });
                        break;
                    case "checkValidatorAliasUser":
                        $(this).change(function () {
                            return checkValidatorAliasUser(this);
                        });
                        break;
                }
                break;

            case "keyPress":
                $(this).data('event', 'keyPressed');
                $(this).unbind('keypress');

                switch (action) {
                    case "searchGrid":
                        $(this).keypress(function () {
                            return searchGrid(event, this);
                        });
                        break;

                    case "searchTerm":
                        $(this).keypress(function () {
                            return searchTerm(event, this);
                        });
                        break;

                    case "changeSearchTerm":
                        $(this).keypress(function () {
                            return changeSearchTerm(event, this);
                        });
                        break;

                }
                break;

            case "keydown":
                $(this).data("event", "keydowned");
                $(this).unbind("keydown");

                switch (action) {
                    case "checkNumber":
                        $(this).bind("keydown", function () {
                            checkNumber(this);
                        });
                        break;

                }
                break;

            case "mouseenter":
                $(this).unbind("mouseenter");

                switch (action) {
                    case "mainMenuExpand":
                        $(this).bind("mouseenter", function () {
                            mainMenuExpand(this);
                        });
                        break;

                }
                break;

            case "mouseleave":
                $(this).unbind("mouseleave");

                switch (action) {
                    case "mainMenuCollapse":
                        $(this).bind("mouseleave", function () {
                            mainMenuCollapse(this);
                        });
                        break;

                }
                break;

            case "toggle":
                $(this).unbind("click");

                switch (action) {
                    case "listSearchbarFilterToggle":
                    $(this).bind("click", function () {
                        listSearchbarFilterToggle(this);
                    });
                    break;

                }
                break;
        }
    });

    $(".tooltipster").each(function () {
        simpleTooltip(this);
    });
}