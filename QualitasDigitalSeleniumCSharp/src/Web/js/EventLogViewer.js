var placeholderDetailOne = {
    "Detail": "Placeholder Event Log Details One"
}
var placeholderDetailTwo = {
    "Detail": "Placeholder Event Log Details Two"
}
var placeholderDetailThree = {
    "Detail": "Placeholder Event Log Details Three"
}
var placeholderDetailFour = {
    "Detail": "Placeholder Event Log Details Four"
}
var placeholderDetailFive = {
    "Detail": "Placeholder Event Log Details Five"
}
var placeholderDetailSix = {
    "Detail": "Placeholder Event Log Details Six"
}

var placeholderDetailArray =
[
    placeholderDetailOne,
    placeholderDetailTwo,
    placeholderDetailThree,
    placeholderDetailFour,
    placeholderDetailFive,
    placeholderDetailSix
    ];

var detailArray = [];

function FillDetails(index) {
    //window.document.getElementById("EventLogDetails").value = placeholderDetailArray[index].Detail;
    window.document.getElementById("EventLogDetails").value = detailArray[index].Detail;
}