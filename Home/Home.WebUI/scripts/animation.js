/***************************version_1.0_*******************************/

/*
$(document).ready(function () {
    $('.col-xs-3_1 a:nth-child(1)').mouseover(function () {
        $('.col-xs-3_1_1').css({ 'height': '35px' });
    });

    $('.col-xs-3_1 a:nth-child(1)').mouseout(function () {
        $('.col-xs-3_1_1').css({ 'height': '0px' });
    });

    $('.col-xs-3_1 a:nth-child(2)').mouseover(function () {
        $('.col-xs-3_1_1').css({ 'height': '70px' });
    });

    $('.col-xs-3_1 a:nth-child(2)').mouseout(function () {
        $('.col-xs-3_1_1').css({ 'height': '0px' });
    });

    $('.col-xs-3_1 a:nth-child(3)').mouseover(function () {
        $('.col-xs-3_1_1').css({ 'height': '105px' });
    });

    $('.col-xs-3_1 a:nth-child(3)').mouseout(function () {
        $('.col-xs-3_1_1').css({ 'height': '0px' });
    });

    $('.col-xs-3_1 a:nth-child(4)').mouseover(function () {
        $('.col-xs-3_1_1').css({ 'height': '140px' });
    });

    $('.col-xs-3_1 a:nth-child(4)').mouseout(function () {
        $('.col-xs-3_1_1').css({ 'height': '0px' });
    });

    $('.col-xs-3_1 a:nth-child(5)').mouseover(function () {
        $('.col-xs-3_1_1').css({ 'height': '175px' });
    });

    $('.col-xs-3_1 a:nth-child(5)').mouseout(function () {
        $('.col-xs-3_1_1').css({ 'height': '0px' });
    });
});*/

/***************************version_2.0_*******************************/

$(document).ready(function () {
    $('.col-xs-3_1 a:nth-child(1)').mouseover(function () {
        $('.col-xs-3_1_1').css({ 'transform': 'translate(0,39px)', 'opacity' : '1' });
    });

    $('.col-xs-3_1 a:nth-child(1)').mouseout(function () {
        $('.col-xs-3_1_1').css({ 'transform': 'translate(0,0)', 'opacity': '0' });
    });

    $('.col-xs-3_1 a:nth-child(2)').mouseover(function () {
        $('.col-xs-3_1_1').css({ 'transform': 'translate(0,72px)', 'opacity': '1' });
    });

    $('.col-xs-3_1 a:nth-child(2)').mouseout(function () {
        $('.col-xs-3_1_1').css({ 'transform': 'translate(0,0)', 'opacity': '0' });
    });

    $('.col-xs-3_1 a:nth-child(3)').mouseover(function () {
        $('.col-xs-3_1_1').css({ 'transform': 'translate(0,105px)', 'opacity': '1' });
    });

    $('.col-xs-3_1 a:nth-child(3)').mouseout(function () {
        $('.col-xs-3_1_1').css({ 'transform': 'translate(0,0)', 'opacity': '0' });
    });

    $('.col-xs-3_1 a:nth-child(4)').mouseover(function () {
        $('.col-xs-3_1_1').css({ 'transform': 'translate(0,138px)', 'opacity': '1' });
    });

    $('.col-xs-3_1 a:nth-child(4)').mouseout(function () {
        $('.col-xs-3_1_1').css({ 'transform': 'translate(0,0)', 'opacity': '0' });
    });

    $('.col-xs-3_1 a:nth-child(5)').mouseover(function () {
        $('.col-xs-3_1_1').css({ 'transform': 'translate(0,171px)', 'opacity': '1' });
    });

    $('.col-xs-3_1 a:nth-child(5)').mouseout(function () {
        $('.col-xs-3_1_1').css({ 'transform': 'translate(0,0)', 'opacity': '0' });
    });
});


$(document).ready(function () {
    $('.well').mouseover(function () {
        $('.btn-xs-01').css({ 'transform': 'scale(1)' });
    });

    $('.well').mouseout(function () {
        $('.btn-xs-01').css({ 'transform': 'scale(0)' });
    });
});
