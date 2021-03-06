 //easy loading
 AOS.init({
  duration: 1200,
})
 

//main slider start
// Hero slider JS
$('.hero-slider').owlCarousel({
  animateOut: 'flipOutY',
  animateIn: 'fadeIn',
  items:1,
  loop:true,
  nav:true,
  dots: true,
  autoplayTimeout:10000,
  autoplay:true
 
  })
  

//main slider end



//service slider start
$(function() {
  $("#owl-service").owlCarousel({
     items: 4,
    margin: 10,
    loop: true,
    nav: false,
    dots: false,
    autoplay:true,
    responsive: {
     250: {
        items: 1
      },
  
     850: {
        items: 2
      },
  
      1200: {
        items: 3
      },
  
      1366: {
        items: 4
      }
    }
 });
 
  });

//service slider end
$('.acc').on('click', function (e) {
    $(".vacan").val("")



});

//subscribe email start

$('#subsc').on('click', function (e) {
    e.preventDefault();
   
    let email = $(".email").val();




    $.ajax({
        url: "/contact/addSubscribe/",
        type: "post",
        dataType: "Json",

        data: { email: email },
        success: function (response) {

            if (response == 200) {
                $(".email").val("")
                alert("Təşəkkür edirik")

            }
            else if (response == 500) {
                alert("Düzgün e-poçt daxil edin")
            }
            else {
                alert("E-poçt elave olunmadi")
            }

        }
    })
})

//subscribe email end

//appointment start

$('#reply').on('click', function (e) {
    e.preventDefault();
    console.log("ok")
   
    let fullname = $(".fullname").val(); 
    let birhtday = $(".birhtday").val();
    let address = $(".address").val();
    let phone = $(".phone").val();
    let unit = $(".unit").val();
    let doctorsFullname = $(".doctorsFullname").val();
    let requestTime = $(".requestTime").val();
    let requestDay = $(".requestDay").val();


    $.ajax({
        url: "/DocRequest/SendMessage/",
        type: "post",
        dataType: "Json",

        data: {
            fullname: fullname, birhtday: birhtday, address: address, phone: phone, unit: unit, doctorsFullname: doctorsFullname, requestTime: requestTime, requestDay: requestDay
           
        },

        success: function (response) {
 
            if (response == 200) {
              
                $(".fullname").val(""),
                    
                    $(".birhtday").val(""),
                    $(".address").val(""),
                    $(".phone").val(""),
                    $(".unit").val(""),
                    $(".doctorsFullname").val(""),
                    $(".requestTime").val(""),
                    $(".requestDay").val("")
                alert("Müraciət qəbul olundu,sizinlə əlaqə saxlanılacaq! Təşəkkür edirik!")
                                     

            }
            else if (response == 400) {
                alert("Xanaları doldurun")
            }
            else if (response == 500) {
                alert("Səhv məlumat")
            }
           
            else {
                alert("Müraciət olunmadi")
            }

        }
    })




})

//appointment end

//doctor slider start
var $owl = $('#owl-doctor');

$owl.children().each( function( index ) {
  $(this).attr( 'data-position', index ); 
});

$owl.owlCarousel({
  
  loop: true,
  items: 5,
  dots:false,
  autoplay:true,
  center:true,
  responsive: {
    200: {
       items: 1
     },
 
    400: {
       items: 3
     },
     900:{
       items:5
     }
 
    
   }
});

$(document).on('click', '.owl-item>div', function() {
  
  var $speed = 300;  
  $owl.trigger('to.owl.carousel', [$(this).data( 'position' ), $speed] );
});

//doctor slider end
//partner slider start
$(function() {
  $("#owl-partners").owlCarousel({
     items: 4,
    margin: 10,
    loop: true,
    nav: false,
    dots: false,
    autoplay:true,
    responsive: {
      200: {
         items: 1
       },
   
      400: {
         items: 2
       },
       600: {
        items: 3
      },
       800: {
        items: 4
      },
   1600:{
     items:5
   }
      
     }
  });
 
  });

//partner slider end



//back to top start

var back_to_top_button = jQuery('.btn-back-to-top');

jQuery(window).scroll(function(){
	if (jQuery(this).scrollTop() > 100 && !back_to_top_button.hasClass('scrolled')) {
		back_to_top_button.addClass('scrolled');
		
	} else if (jQuery(this).scrollTop() < 100 && back_to_top_button.hasClass('scrolled')) {
		back_to_top_button.removeClass('scrolled');
		
	}
});

//click to scroll to top
back_to_top_button.click(function(){
    jQuery('html, body').animate({scrollTop : 0},800);
    return false;
});
//back to top end

//clock start

var clockH = $(".hours");
var clockM = $(".minutes");

function time() {     
  var d = new Date(),
      s = d.getSeconds() * 6,
      m = d.getMinutes() * 6 + (s / 60),
      h = d.getHours() % 12 / 12 * 360 + (m / 12);  
    clockH.css("transform", "rotate("+h+"deg)");
    clockM.css("transform", "rotate("+m+"deg)");  
}

var clock = setInterval(time, 1000);
time();

//clock end


 //navbar fixed

 $(window).scroll(function (e) {
  if ($(this).scrollTop() > 85) {
    $(".header-main").addClass("header-fixed");
  } else {
    $(".header-main").removeClass("header-fixed");
  }
});
//filter doctor

$('.doctor-item').isotope({
  itemSelector: '.item',
  layoutMode: 'fitRows'
});
$('.portfolio-menu ul li').click(function(){
  $('.portfolio-menu ul li').removeClass('active').css("color","black");
  $(this).addClass('active').css("color","red");
   
  var selector = $(this).attr('data-filter');
  $('.doctor-item').isotope({
    filter: selector
  });

return false;

});
