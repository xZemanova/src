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
});
