$(".checkBoxClass").click(function () {
    var cid = $(this).data('checkboxid');
    var ivmurl = '/ItemViewModel/Update';
    $.ajax({
        type: "POST",
        url: ivmurl,
        data: { 'sid': cid },
        success: function (res) {
            console.log(res);
        },
        error: function (res) {
            alert("Fel");
        }
    });
})

$(".trashCanClass").click(function () {
    var cid = $(this).attr("id");
    var ivmurl = '/ItemViewModel/Delete';
    $.ajax({
        type: "POST",
        url: ivmurl,
        data: { 'id': cid },
        success: function (res) {
            console.log(res);
            location.reload(true);
        },
        error: function (res) {
            alert("Fel");
        }
    });
})