﻿// use jQuery to attach a confirmation popup to any element with the class "confirmation"

$('.confirmation').on('click', function () {
    return confirm('Are you sure you want to delete this?');
});