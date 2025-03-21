var Savereg = function ()
{
    debugger;
    $formData = new FormData(); var image = document.getElementById('fuimage'); if (image.files.length > 0) {
        for (var i = 0; i < image.files.length; i++)
        {
            $formData.append('fuimage' + i, image.files[i]);
        }
    }
        var FeedbackId = $("#hdnID").val();
        var Name = $("#txtname").val();
        var MobNo = $("#txtmobno").val();
        var Email = $("#txtemail").val();
        var Technology = $("#txttechnology").val();
        var Office = $("#txtoffice").val();
        var CompSelected = $("#txtcompselected").val();
        var Feedback1 = $("#txtfeedback").val();
        var Image = $("#fuimage").val();

    $formData.append('Name', Name);
    $formData.append('MobNo', MobNo);
    $formData.append('Email', Email);
    $formData.append('Technology', Technology);
    $formData.append('Office', Office);
    $formData.append('CompSelected', CompSelected);
    $formData.append('Feedback1', Feedback1);
    $formData.append('image', image);

    $.ajax({
        url: "/Feedback/Savereg",
        method: "post",
        data: $formData,
        dataType: "JSON",
        contentType: false,
        processData: false,     

        success: function (response) {
            alert(response.Message);

        }
    });
}


//    debugger;
//    var FeedbackId = $("#hdnID").val();
//    var Name = $("#txtname").val();
//    var MobNo = $("#txtmobno").val();
//    var Email = $("#txtemail").val();
//    var Technology = $("#txttechnology").val();
//    var Office = $("#txtoffice").val();
//    var CompSelected = $("#txtcompselected").val();
//    var Feedback1 = $("#txtfeedback").val();
//    var Image = $("#image").val();
//    var model =
//    {

//        FeedbackId: FeedbackId,
//        Name: Name,
//        MobNo: MobNo,
//        Email: Email,
//        Technology: Technology,
//        Office: Office,
//        CompSelected: CompSelected,
//        Feedback1: Feedback1,
//        Image: Image,
//    };
    if (Name == "") {
        alert("please enter name");
        $("#txtname").focus();
        return false;
    }
    var filter = /^[0-9]{10}/;
    if (!filter.test(MobNo)) {
        alert("please enter MobileNumber");
        $("#txtmobno").focus();
        return false;
    }
     
    
    else if (Email == "") {
        alert("please enter Email");
        $("#txtemail").focus();
        return false;
    }

    else if (Technology == "") {
        alert("please enter Technology");
        $("#txttechnology").focus();
        return false;
    }

    else if (Office == "") {
        alert("please enter Office");
        $("#txtoffice").focus();
        return false;
    }
    else if (CompSelected == "") {
        alert("please enter CompSelected");
        $("#txtcompselected").focus();
        return false;
    }
    else if (Feedback1 == "") {
        alert("please enter Feedback1");
        $("#txtfeedback").focus();
        return false;
    }
    else if (Image == "") {
        alert("please enter Image");
        $("#image").focus();
        return false;
    }
    $.ajax({
        url: "/Feedback/Savereg",
        method: "post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (response)
        {
            alert(response.Message);
        }
    });
}