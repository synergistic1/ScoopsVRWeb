$(document).ready(function () {
    $("#dialog").dialog({
        autoOpen: false,
        modal: true
    });

})


$(".panel-footer").on("click", function (e) {
    e.preventDefault();

    var targetPost = $(this).children("#ID").val();
    console.log(targetPost);

    $.ajax({
        type: "POST",
        url: "http://localhost:58074/GetPostByID",
        data: {id: targetPost + ''},
        success: function (data) {
            showDialog(data);
        },
        error: function (xhr, textStatus, errorThrown) {
            console.log(errorThrown);
        }
    });

});


function showDialog(postData) {
    $("#dialog").children("p").html(postData.content);
    console.log($("#dialog p img"));
    $("#dialog p img").remove();
    
    $("#dialog").dialog("option", "title", postData.title);

    $("#dialog").dialog("open");


}


