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
        var RestaurantId = 0;
        var Taste = $('input[name=taste]:checked', '#taste').val();
        var Texture = $('input[name=texture]:checked', '#texture').val();
        var Presentation = $('input[name=presentation]:checked', '#presentation').val();

        $('input[name=radioName]:checked', '#myForm').val()
        $.ajax(
            {
                type: "POST",
                url: 'Home/AddPicture?fileName=' + fileName + '&fileContentType=' + fileContentType
            });
    });
});
