var EventData =
[
    {
        "Level": "Level Placeholder",
        "DateAndTime": "Date and Time Placeholder",
        "Source": "Source Placeholder",
        "Task Category": "Task Category Placeholder"
    },
    {
        "Level": "Level Placeholder",
        "DateAndTime": "Date and Time Placeholder",
        "Source": "Source Placeholder",
        "Task Category": "Task Category Placeholder"
    },
    {
        "Level": "Level Placeholder",
        "DateAndTime": "Date and Time Placeholder",
        "Source": "Source Placeholder",
        "Task Category": "Task Category Placeholder"
    },
    {
        "Level": "Level Placeholder",
        "DateAndTime": "Date and Time Placeholder",
        "Source": "Source Placeholder",
        "Task Category": "Task Category Placeholder"
    },
    {
        "Level": "Level Placeholder",
        "DateAndTime": "Date and Time Placeholder",
        "Source": "Source Placeholder",
        "Task Category": "Task Category Placeholder"
    },
    {
        "Level": "Level Placeholder",
        "DateAndTime": "Date and Time Placeholder",
        "Source": "Source Placeholder",
        "Task Category": "Task Category Placeholder"
    }
];

var detailData =
[
    {
        "Details": "Event Details Placeholder One"
    },
    {
        "Details": "Event Details Placeholder Two"
    },
    {
        "Details": "Event Details Placeholder Three"
    },
    {
        "Details": "Event Details Placeholder Four"
    },
    {
        "Details": "Event Details Placeholder Five"
    },
    {
        "Details": "Event Details Placeholder Six"
    }
];
function addDataToTbody(nl, data) { // nl -> NodeList, data -> array with objects
    data.forEach((d, i) => {
        var tr = nl.insertRow(i);
        Object.keys(d).forEach((k, j) => { // Keys from object represent th.innerHTML
            tr.setAttribute("onclick", "FillDetails(this.rowIndex-1);");
            var cell = tr.insertCell(j);
            cell.innerHTML = d[k]; // Assign object values to cells   
        });
        nl.appendChild(tr);
    });
}

var eventTableBody = document.querySelector("#EventLogTable");

addDataToTbody(eventTableBody, EventData);

function FillDetails(index) {
    window.document.querySelector("#EventLogDetails").value = detailData[index].Details;
}