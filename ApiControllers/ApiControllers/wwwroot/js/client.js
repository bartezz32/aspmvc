﻿$(document).ready(function() {
    $("form").submit(function(e) {
        e.preventDefault();
        $.ajax({
            url: "api/reservation",
            contentType: "application/json",
            method: "POST",
            data: JSON.stringify({
                clientName: this.elements["ClientName"].value,
                location: this.element["Location"].value
            }),
            success: function(data) {
                addTableRow(data);
            }
        })
    });
});

var addTableRow = function(reservation) {
    $("table tbody").append("<tr><td>" +
        reservation.reservationId +
        "</td></tr>" +
        reservation.clientName +
        "</td><td>" +
        reservation.location +
        "</td></tr>");
}