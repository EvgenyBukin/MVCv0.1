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
        $(this).find('.btn-xs-01').css({ 'transform': 'scale(1)' });
    });

    $('.well').mouseout(function () {
        $(this).find('.btn-xs-01').css({ 'transform': 'scale(0)' });
    });
});


$(document).ready(function () {
    $('.btn-xs-Article-01').mouseover(function () {
        $('.ArticleImg1').css({ 'filter': 'blur(2px)', '-webkit-filter': 'blur(2px)', '-moz-filter': 'blur(2px)', '-ms-filter': 'blur(2px)', '-o-filter': 'blur(2px)' });
    });

    $('.btn-xs-Article-01').mouseout(function () {
        $('.ArticleImg1').css({ 'filter': 'blur(0px)', '-webkit-filter': 'blur(0px)', '-moz-filter': 'blur(0px)', '-ms-filter': 'blur(0px)', '-o-filter': 'blur(0px)' });
    });
});

$(document).ready(function () {
    $('.moduleSize').click(function () {
        if ($('.moduleSize').attr('id') == 'positionOne') {
            $('.moduleSize').attr('id', 'positionTwo');
            $('#videoArticle').css({ 'width' : '986px', 'height' : '580px', 'transition-duration' : '1s' });
            $('.contentBodyArticle01').css({ 'width': '986px', 'height' : '580px', 'transition-duration' : '1s' });
            $('.moduleSize').css({ 'position': 'none', 'background' : 'rgb(74, 139, 160)', 'float': 'right', 'width': '45px', 'height': '580px', 'margin-left': '987px', 'top': '60px', 'transition-duration': '1s' });
            $('#modulSizeImg').css({ 'transform': 'rotate(-90deg)', 'width': '35px', 'transition-duration': '1s' });
            $('.contentBodyArticle02').css({ 'width': '0px', 'height': '0px', 'transition-duration': '1s' });
            setTimeout(function () {
                $('.contentBodyArticle02').css({ 'width': '1025px' });
            }, 900);
            setTimeout(function () {
                $('.contentBodyArticle02').css({ 'height': '120px', 'transition-duration': '1s' });
            }, 1000);
        } else {
            $('#videoArticle').css({ 'width': '757px', 'height': '425px', 'transition-duration': '1s' });
            $('.contentBodyArticle01').css({ 'width': '757px', 'height': '425px', 'transition-duration': '1s' });
            $('.moduleSize').css({ 'position': 'none', 'background' : 'rgb(221, 221, 221)', 'float': 'right', 'width': '274px', 'height': '45px', 'margin-left': '758px', 'top': '439px', 'transition-duration': '1s' });
            $('#modulSizeImg').css({ 'transform': 'rotate(0deg)', 'width': '35px', 'transition-duration': '1s' });
            $('.moduleSize').attr('id', 'positionOne');
            setTimeout(function () {
                $('.contentBodyArticle02').css({  'height': '0px', 'opacity' : '0', 'transition-duration': '1s' });
            }, 0);
            setTimeout(function () {
                $('.contentBodyArticle02').css({ 'width': '275px' });
            }, 100);
            setTimeout(function () {
                $('.contentBodyArticle02').css({ 'height': '425px', 'opacity': '1', 'transition-duration': '1s' });
            }, 1100);
        }
    })
});

$(document).ready(function () {
    $('.col-xs-4_3_1').mouseover(function () {
        $(this).find('.col-xs-4_3_1_Img1').animate({ top : '-10px' }, 1000);
    })

    $('.col-xs-4_3_1').mouseout(function () {
        $(this).find('.col-xs-4_3_1_Img1').animate({ top: '0px' }, 1000);
    })
});

/*
$(document).ready(function () {
    $('.col-xs-4_3_1').mouseover(function () {
        $(this).find('.col-xs-4_3_1_Img1').css({ 'transition-duration': '1s', 'top': '-10px' });
    })

    $('.col-xs-4_3_1').mouseout(function () {
        $(this).find('.col-xs-4_3_1_Img1').css({ 'transition-duration': '1s', 'top': '0px' });
    })
});*/

$(document).ready(function () {
    $('.well').find('.wellCatigory').css({
        'background': 'rgb(57, 62, 68)',
        'position': 'absolute',
        'padding': '5px',
        'color': 'rgb(255, 255, 255)',
        'z-index': '11',
        'margin-top': '10px',
        'margin-left': '5px'
    })

    $('.wellCatigory[data-attribute=Новости]').css({
        'background': 'rgb(74, 139, 160)'
    })
});


