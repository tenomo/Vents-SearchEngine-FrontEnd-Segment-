// test code  $.getJSON =====================

//$(function () {
//    alert("test work jq");
//    $.getJSON(
//        "TestGet",
//        null,
//        function (str) {
//            alert(str);
//        }
//        );
//    }
//);

// end test code  $.getJSON =====================


// test serch http get method on the $.getJSON ==========

// SearchBtn click event handler
function Search_BtnClick() {
    // result search TextBox
    var searchResault = document.getElementById("SearchTextBox").value;
    // wrapper for segment name, contains field segmentName and him value
    var segmentName = { segmentName: searchResault }

    // =========  удаление устаревших эелементов ====================
    var elements = document.getElementsByName("search-result-item");//
    for (var i = 0; i <= elements.length - 1; i++)                 //
    {                                                              //
        elements[i].parentNode.removeChild(elements[i]);           // 
        // 
    }                                                              //
    //==============================================================

    // Jquery on to Home/Search and perform ViewList(data)
    $.getJSON("Home/Search", segmentName, ViewSearchResult);

    // $.ajax("Home/Search").done(function (data) { t = data });

    //  alert("полученое значение:  " + t.toString());
}

function ViewSearchResult(searchResult) {
    $.each(searchResult, function (i) {

        var buildHtmlElement = '<p>' +
            '<input type="button"  class="btn btn-success" name = "search-result-item" value=' + this.Name +
             ' onclick="GetModel_BtnClick(' +
             this.Id +
            ')">' +
             '</p>';
        $("#search-result").append(buildHtmlElement);
    });
}

function GetModel_BtnClick(id) {
    var transferId = { modelId: id }
    $.getJSON("Home/GetTestModel", transferId, ViewSldModel
);
}

function ViewSldModel(sldModel) {
    //         test
    //  alert(sldModel.Model);
    //=================

    //var eDrawingControllFileName = document.getElementById("eDrawings-controll-FileName");
    $('#eDrawings-controll-FileName').val(sldModel.Model);
}