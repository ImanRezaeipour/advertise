/**
 *
 * @param {} elem
 * @returns {}
 */
var uploaderCompanyImage = function (elem, isEdit) {
    var uploaderOptions = {
        elementId: $(elem).attr('name'),
        modelId: $("#Id").val(),
        initializeUrl: "/CompanyImage/getfilesajax",
        modelField: "CompanyImageFile[*].FileName",
        modelFieldIndex: "CompanyImageFile.Index",
        isEditable: isEdit,
        requestParams: { imageType: "CompanyImages" }
    }

    $(elem).appUploader(uploaderOptions);
}
var uploaderCompanyAttachment = function (elem, isEdit) {
    var uploaderOptions = {
        elementId: $(elem).attr('name'),
        modelId: $("#Id").val(),
        initializeUrl: "/CompanyAttachment/getfilesajax",
        modelField: "CompanyAttachmentFile[*].FileName",
        modelFieldIndex: "CompanyAttachmentFile.Index",
        isEditable: isEdit,
        requestParams: { imageType: "Nan" }
    }

    $(elem).appUploader(uploaderOptions);
}

/**
 * 
 * @param {} elem 
 * @returns {} 
 */
var uploaderCategory = function (elem, isEdit) {
    var uploaderOptions = {
        elementId: $(elem).attr('name'),
        modelId: $("#Id").val(),
        initializeUrl: "/category/getfileajax",
        modelField: "ImageFileName",
        modelFieldIndex: "ImageFileName.Index",
        isEditable: isEdit,
        isMultiple: false,
        requestParams: { imageType: "Nan" }
    }

    $(elem).appUploader(uploaderOptions);
}

/**
 *
 * @param {} elem
 * @returns {}
 */
var uploaderCompany = function (elem, isEdit) {
    var uploaderOptions = {
        elementId: $(elem).attr('name'),
        modelId: $("#Id").val(),
        initializeUrl: "/company/getfileajax",
        modelField: "LogoFileName",
        modelFieldIndex: "LogoFileName.Index",
        isEditable: isEdit,
        isMultiple: false,
        requestParams: { imageType: "LogoFileName" }
    }

    $(elem).appUploader(uploaderOptions);
}

/**
 *
 * @param {} elem
 * @returns {}
 */
var uploaderCompanyCover = function (elem, isEdit) {
    var uploaderOptions = {
        elementId: $(elem).attr('name'),
        modelId: $("#Id").val(),
        initializeUrl: "/company/getfilecoverajax",
        modelField: "CoverFileName",
        modelFieldIndex: "CoverFileName.Index",
        isEditable: isEdit,
        isMultiple: false,
        requestParams: { imageType: "CompanyCoverFileName" }
    }

    $(elem).appUploader(uploaderOptions);
}

/**
 *
 * @param {} elem
 * @returns {}
 */
var uploaderProductImages = function (elem, isEdit) {
    var uploaderOptions = {
        elementId: $(elem).attr('name'),
        modelId: $("#Id").val(),
        initializeUrl: "/product/getfilesajax",
        modelField: "Images[*].FileName",
        modelFieldIndex: "Images.Index",
        isEditable: isEdit,
        requestParams: { "imageType": "ProductImages" }
    }

    $(elem).appUploader(uploaderOptions);
}

/**
 *
 * @param {} elem
 * @returns {}
 */
var uploaderProductImage = function (elem, isEdit) {
    var uploaderOptions = {
        elementId: $(elem).attr('name'),
        modelId: $("#Id").val(),
        initializeUrl: "/product/getfileajax",
        modelField: "ImageFileName",
        modelFieldIndex: "ImageFileName.Index",
        isEditable: isEdit,
        isMultiple: false,
        requestParams: { imageType: "ProductImage" }

    }

    $(elem).appUploader(uploaderOptions);
}

/**
 * 
 * @param {} elem 
 * @returns {} 
 */
var uploaderTag = function (elem, isEdit) {
    var uploaderOptions = {
        elementId: $(elem).attr('name'),
        modelId: $("#Id").val(),
        initializeUrl: "/tag/getfilesajax",
        modelField: "LogoFileName",
        modelFieldIndex: "LogoFileName.Index",
        isEditable: isEdit,
        requestParams: { imageType: "LogoFileName" }
    }

    $(elem).appUploader(uploaderOptions);
}

/**
 * 
 * @param {} elem 
 * @returns {} 
 */
var uploaderUser = function (elem, isEdit) {
    var uploaderOptions = {
        elementId: $(elem).attr('name'),
        modelId: $("#Id").val(),
        initializeUrl: "/user/avatarajax",
        modelField: "AvatarFileName",
        modelFieldIndex: "AvatarFileName.Index",
        isEditable: isEdit,
        isMultiple: false,
        requestParams: { imageType: "LogoFileName" }
    }

    $(elem).appUploader(uploaderOptions);
}

/**
 *
 * @param {} elem
 * @returns {}
 */

var uploaderCompanyAttachment = function (elem, isEdit) {
    var uploaderOptions = {
        elementId: $(elem).attr('name'),
        modelId: $("#Id").val(),
        initializeUrl: "/gallery/getfilesajax",
        modelField: "CompanyAttachmentFile[*].FileName",
        modelFieldIndex: "CompanyAttachmentFile.Index",
        isEditable: isEdit,
        requestParams: { imageType: "Nan" }
    }

    $(elem).appUploader(uploaderOptions);
}

/**
 *
 * @param {} elem
 * @returns {}
 */
var uploaderCompanyVideo = function (elem, isEdit) {
    var uploaderOptions = {
        elementId: $(elem).attr("name"),
        modelId: $("#Id").val(),
        initializeUrl: "/gallery/getfilesajax",
        modelField: "CompanyVideoFile[*].FileName",
        modelFieldIndex: "CompanyVideoFile.Index",
        isEditable: isEdit,
        requestParams: { imageType: null }
    }

    $(elem).appUploader(uploaderOptions);
}
