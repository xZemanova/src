$(function () {
    var _reviewService = abp.services.app.review;
    var _pictureService = abp.services.app.picture;
    var _restaurantService = abp.services.app.restaurant;
    var _$modalRw = $('#ReviewCreateModal');
    var _$modalRs = $('#RestaurantCreateModal');
    var _$form = $('#TestForm').find('form');
    
    $('#btnSave').click(function () {

        var picture = _$form.serializeFormToObject();

        _pictureService.create(picture).done(function () {
            alert("New picture");
        });
        /*
        $.ajax(
            {
                type: "POST",
                url: 'Home/AddPicture?fileName=' + fileName + '&fileContentType=' + fileContentType,
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (msg) {
                    alert("Success. " + msg);
                },
                error: function (request, message, error) {
                    alert("Error: " + error);
                    handleException(request, message, error);
                }
            });*/
    });
    $('#btnSaveReview').click(function () {

        var review = $("#reviewCreateForm").serializeFormToObject();

        _reviewService.create(review).done(function () {
            _$modalRw.modal('hide');
            location.reload(true); //reload page to see new review!
        }).always(function () {
            abp.ui.clearBusy(_$modalRw);
        });
    });
    $('#btnSaveRestaurant').click(function () {

        var restaurant = $("#restaurantCreateForm").serializeFormToObject();

        _restaurantService.create(restaurant).done(function () {
            _$modalRs.modal('hide');
            location.reload(true); //reload page to see new restaurant!
        }).always(function () {
            abp.ui.clearBusy(_$modalRs);
        });
    });
    /*
        var restaurantId = 0;
        /*var taste = $('input[name=taste]:checked', '#taste').val();
        var texture = $('input[name=texture]:checked', '#texture').val();
        var presentation = $('input[name=presentation]:checked', '#presentation').val();*/
    /*
        var taste = 5;
        var texture = 5;
        var presentation = 5;

        var createReview = {
            RestaurantId: restaurantId,
            Taste: taste,
            Texture: texture,
            Presentation: presentation
        }
         
        $.ajax(
            {
                type: "POST",
                url: 'Home/AddReview',
                contentType: "application/json; charset=utf-8",
                dataType: "json", 
                success: function (msg) {
                    alert("Success. " + msg);
                },
                error: function (XMLHttpRequest, textStatus, errorThrown) {
                    alert("Status: " + textStatus); alert("Error: " + errorThrown);
                }
            });
    });*/
});
