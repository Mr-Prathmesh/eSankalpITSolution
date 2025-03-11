
var Savereg = function () {
    debugger;
    var RegID = $("#hdnID").val();
    var Name = $("#txtname").val();
    var MobileNo = $("#txtmobile").val();
    var Email = $("#txtemail").val();
    var Education = $("#txteducation").val();
    var Percentage = $("#txtpercentage").val();
    var Service = $("#txtservice").val();
    var Technology = $("#txttechnology").val();
    var Office = $("#txtoffice").val();
    var College = $("#txtcollege").val();
    var Address = $("#txtaddress").val();
    var model =
    {
        RegId: RegID,
        Name: Name,
        MobileNo: MobileNo,
        Email: Email,
        Education: Education,
        Percentage: Percentage,
        Service: Service,
        Technology: Technology,
        Office: Office,
        College: College,
        Address: Address,

    };
    $.ajax({
        url: "/IntershipRegistration/Savereg",
        method: "post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (response) {
            //getlist();
            //ClearForm();
            alert(response.Message);
        }
    });
}