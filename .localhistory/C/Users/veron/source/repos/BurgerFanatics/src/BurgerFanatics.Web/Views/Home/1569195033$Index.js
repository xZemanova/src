$(function () {
    //Widgets count
    $('.count-to').countTo();

    //Sales count to
    $('.sales-count-to').countTo({
        formatter: function (value, options) {
            return '$' + value.toFixed(2).replace(/(\d)(?=(\d\d\d)+(?!\d))/g, ' ').replace('.', ',');
        }
    });

    $('#btnSave').click(function () {
        var fileName = $("#txtName").val();
        var fileContentType = $("#txtExt").val();

        $.ajax(
            {
                type: "POST",
                url: 'Home/AddPicture?fileName=' + fileName + '&fileContentType=' + fileContentType
            });
    });

    $('#btnSaveReview').click(function () {
        var restaurantId = 0;
        /*var taste = $('input[name=taste]:checked', '#taste').val();
        var texture = $('input[name=texture]:checked', '#texture').val();
        var presentation = $('input[name=presentation]:checked', '#presentation').val();*/
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
                url: 'AddReview?input=' + createReview,
                contentType: "application/json; charset=utf-8",
                dataType: "json", 
                success: function (msg) {
                    alert("Success. " + msg);
                },
                error: function (XMLHttpRequest, textStatus, errorThrown) {
                    alert("Status: " + textStatus); alert("Error: " + errorThrown);
                }
            });
    });
});
