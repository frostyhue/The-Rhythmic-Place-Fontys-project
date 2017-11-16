/*! Gallery*/

window.addEventListener('load', onWndLoad, false);

function onWndLoad() {
   
    var slider = document.querySelector('.slider');
    var sliders = slider.children;
   
   
   
   
    var initX = null;  
    var transX = 0;
    var rotZ = 0;
    var transY = 0;
   
    var curSlide = null;
    
    var Z_DIS = 50;
    var Y_DIS = 10;
    var TRANS_DUR = 0.4;
  
     var images=document.querySelectorAll('img');
  for(var i=0;i<images.length;i++)
    {
      images[i].onmousemove=function(e){
        e.preventDefault()
        
      }
      images[i].ondragstart=function(e){
        return false;
        
      }
    }
  
    function init() {
       
        var z = 0, y = 0;

        for (var i = sliders.length-1; i >=0; i--) {
            sliders[i].style.transform = 'translateZ(' + z + 'px) translateY(' + y + 'px)';
           
            z -= Z_DIS;
            y += Y_DIS;
        }


        attachEvents(sliders[sliders.length - 1]);

      
       
    }
    function attachEvents(elem) {
        curSlide = elem;

        curSlide.addEventListener('mousedown', slideMouseDown, false);
        curSlide.addEventListener('touchstart', slideMouseDown, false);
    }
    init();
    function slideMouseDown(e) {
    
        if (e.touches) {
            initX = e.touches[0].clientX;
        }
        else {
            initX = e.pageX;
        }
     
       
        document.addEventListener('mousemove', slideMouseMove, false);
        document.addEventListener('touchmove', slideMouseMove, false);

        document.addEventListener('mouseup', slideMouseUp, false);
        document.addEventListener('touchend', slideMouseUp, false);
    }
    var prevSlide = null;
   
    function slideMouseMove(e) {
        var mouseX;
      
        if (e.touches) {
            mouseX = e.touches[0].clientX;
        }
        else {
            mouseX = e.pageX;
        }

        transX += mouseX - initX;
        rotZ = transX / 20;

        transY = -Math.abs(transX / 15);
     
      
      
        curSlide.style.transition = 'none';
        curSlide.style.webkitTransform = 'translateX(' + transX + 'px)' + ' rotateZ(' + rotZ + 'deg)' + ' translateY(' + transY + 'px)';
       curSlide.style.transform = 'translateX(' + transX + 'px)' + ' rotateZ(' + rotZ + 'deg)' + ' translateY(' + transY + 'px)';
        var j = 1;
        //remains elements
         for (var i = sliders.length -2; i >= 0; i--) {

        sliders[i].style.webkitTransform = 'translateX(' + transX/(2*j) + 'px)' + ' rotateZ(' + rotZ/(2*j) + 'deg)' + ' translateY(' + (Y_DIS*j) + 'px)'+ ' translateZ(' + (-Z_DIS*j) + 'px)';
        sliders[i].style.transform = 'translateX(' + transX/(2*j) + 'px)' + ' rotateZ(' + rotZ/(2*j) + 'deg)' + ' translateY(' + (Y_DIS*j) + 'px)'+ ' translateZ(' + (-Z_DIS*j) + 'px)';
        sliders[i].style.transition = 'none';
        j++;
        }      
        
          
         
          initX =mouseX;
          e.preventDefault();
          if (Math.abs(transX) >= curSlide.offsetWidth-30) {
           
              document.removeEventListener('mousemove', slideMouseMove, false);
              document.removeEventListener('touchmove', slideMouseMove, false);
              curSlide.style.transition = 'ease 0.2s';
              curSlide.style.opacity = 0;
              prevSlide = curSlide;
              attachEvents(sliders[sliders.length - 2]);
              slideMouseUp();
              setTimeout(function () {
                 
               
                 
               
                  
                  slider.insertBefore(prevSlide, slider.firstChild);
                  
                  prevSlide.style.transition = 'none';
                  prevSlide.style.opacity = '1';
                  slideMouseUp();
                
              },201);
            
             
              
              return;
          }
    }
    function slideMouseUp() {
        transX = 0;
        rotZ = 0;
        transY = 0;
      
        curSlide.style.transition = 'cubic-bezier(0,1.95,.49,.73) '+TRANS_DUR+'s';

        curSlide.style.webkitTransform = 'translateX(' + transX + 'px)' + 'rotateZ(' + rotZ + 'deg)' + ' translateY(' + transY + 'px)';
       curSlide.style.transform = 'translateX(' + transX + 'px)' + 'rotateZ(' + rotZ + 'deg)' + ' translateY(' + transY + 'px)';
        //remains elements
        var j = 1;
        for (var i = sliders.length -  2; i >= 0; i--) {
               sliders[i].style.transition = 'cubic-bezier(0,1.95,.49,.73) ' + TRANS_DUR / (j + 0.9) + 's';
        sliders[i].style.webkitTransform = 'translateX(' + transX + 'px)' + 'rotateZ(' + rotZ + 'deg)' + ' translateY(' + (Y_DIS*j) + 'px)' + ' translateZ(' + (-Z_DIS*j) + 'px)';
           sliders[i].style.transform = 'translateX(' + transX + 'px)' + 'rotateZ(' + rotZ + 'deg)' + ' translateY(' + (Y_DIS*j) + 'px)' + ' translateZ(' + (-Z_DIS*j) + 'px)';

        j++;
        }
         
        document.removeEventListener('mousemove', slideMouseMove, false);
        document.removeEventListener('touchmove', slideMouseMove, false);
     
    }


}

/* about page*/

(function() {
  var $slides = document.querySelectorAll('.slides');
  var $controls = document.querySelectorAll('.sliders__control');
  var numOfSlides = $slides.length;
  var slidingAT = 1300; // sync this with scss variable
  var slidingBlocked = false;

  [].slice.call($slides).forEach(function($el, index) {
    var i = index + 1;
    $el.classList.add('slides-' + i);
    $el.dataset.slide = i;
  });

  [].slice.call($controls).forEach(function($el) {
    $el.addEventListener('click', controlClickHandler);
  });

  function controlClickHandler() {
    if (slidingBlocked) return;
    slidingBlocked = true;

    var $control = this;
    var isRight = $control.classList.contains('m--right');
    var $curActive = document.querySelector('.slides.s--active');
    var index = +$curActive.dataset.slide;
    (isRight) ? index++ : index--;
    if (index < 1) index = numOfSlides;
    if (index > numOfSlides) index = 1;
    var $newActive = document.querySelector('.slides-' + index);

    $control.classList.add('a--rotation');
    $curActive.classList.remove('s--active', 's--active-prev');
    document.querySelector('.slides.s--prev').classList.remove('s--prev');
    
    $newActive.classList.add('s--active');
    if (!isRight) $newActive.classList.add('s--active-prev');
    

    var prevIndex = index - 1;
    if (prevIndex < 1) prevIndex = numOfSlides;

    document.querySelector('.slides-' + prevIndex).classList.add('s--prev');

    setTimeout(function() {
      $control.classList.remove('a--rotation');
      slidingBlocked = false;
    }, slidingAT*0.75);
  };
}());

/*footer*/
$(function () {
    var iframe = $('.main-content iframe')[0],
        menu_links = $('.items li a'),
        selected_link,
        href;


    $(window).on('hashchange', function() {

        if(window.location.hash){
            href = window.location.hash.substring(1);
            selected_link = $('a[href$="'+href+'"]');

            // Check if the hash is valid - it should exist as one of the menu items.
            if(selected_link.length){
                iframe.contentWindow.location.replace(href + '.html');

                menu_links.removeClass('active');
                selected_link.addClass('active');
            }
        }
        else{
            iframe.contentWindow.location.replace('Footer-with-logo.html');
            menu_links.removeClass('active');
            $(menu_links[0]).addClass('active');
        }

    });


    if(window.location.hash){
        $(window).trigger('hashchange');
    }


    menu_links.on('click', function (e) {
        e.preventDefault();

        window.location.hash = $(this).attr('href');
    });


    $('#template-select').on('change', function (e) {
        e.preventDefault();

        window.location.hash = $(this).find(':selected').data('href');
    });

});

/*navbar darker background after scroll*/

//window.onscroll = function() {
//    var nav = document.getElementById('nav');
//    var right = document.getElementById('right');
//    if ( window.pageYOffset > 1 ) {
//        nav.classList.add("nav");
//        right.classList.add("padding-right");
//    } else {
//        nav.classList.remove("nav");
//        right.classList.remove("padding-right");
//    }
//}

/*menu*/
function openNav() {
    document.getElementById("mySidenav").style.width = "250px";
}

function closeNav() {
    document.getElementById("mySidenav").style.width = "0";
}

// clicking outside and closing the form
var modal = document.getElementById('id01');    

// When the user clicks anywhere outside of the modal, close it
window.onclick = function(event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
}
