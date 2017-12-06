<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
  <head>
    <title>The Rhythmic Place</title>
      <link rel="stylesheet" href="font/font-awesome-4.7.0/css/font-awesome.min.css">
      <link href="style/style.css" style="text/css" rel="stylesheet">
      <link rel="stylesheet" type="text/css" href="font/Open_Sans.css">
      
      <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, user-scalable=no">
    <meta name="mobile-web-app-capable" content="yes">
      
  </head>
  <body>
      <div id="body" class="container" >
          <nav class="navigation" id="nav">
              <div class="fixed-corner-left"><img class="logo" src="images/logo2.png"></div>
              <div class="right" id="right">
                  <div class="toggle-icon" onclick="openNav()">
    <span class="bar" onclick="openNav()"></span>
    <span class="bar" onclick="openNav()"></span>
    <span class="bar" onclick="openNav()"></span>
  </div><!-- /toggle-icon -->
              </div>
              <div id="mySidenav" class="sidenav">
                  <li><a href="javascript:void(0)" class="closebtn" onclick="closeNav()">&times;</a></li>
                  <li><a href="#home">Home</a></li>
                <li><a href="#artists">Artists</a></li>
                <li><a href="#gallery">Gallery</a></li>
                <li><a href="#join">Join</a></li>
                <li><a href="#map">Location</a></li>
                <li><a onclick="document.getElementById('id01').style.display='block'" style="width:auto;">Log in</a></li>
                  <div class="align-icons">
                  <ul >
                      <li><a href="#"><i class="fa fa-facebook" aria-hidden="true"></i></a></li>
                      <li><a href="#"><i class="fa fa-instagram" aria-hidden="true"></i></a></li>
                      <li><a href="#"><i class="fa fa-twitter" aria-hidden="true"></i></a></li>
                      <li><a href="#"><i class="fa fa-youtube" aria-hidden="true"></i></a></li>
                  </ul>
                  </div>
</div>
          </nav>
          

<!--          logo in the left corner-->
         <div id="id01" class="modal">
  
  <form class="modal-content animate" action="/action_page.php">
    <div class="imgcontainer">
      <span onclick="document.getElementById('id01').style.display='none'" class="close" title="Close Modal">&times;</span>
      <img src="img_avatar2.png" alt="Avatar" class="avatar">
    </div>

    <div class="container-form">
      <label><b>Username</b></label>
      <input type="text" placeholder="Enter Username" name="uname" required>

      <label><b>Password</b></label>
      <input type="password" placeholder="Enter Password" name="psw" required>
        
      <button class="button-form" type="submit">Login</button>
      <input type="checkbox" checked="checked"> Remember me</div>
  </form>
</div>
<!--    navigation-->
<!--
    <nav class="navigation" id="nav">
         <div class="fixed-corner-left"><img class="logo" src="images/logo.png"></div>
        <div class="right" id="right">
            <ul>
                <li><a href="#home">Home</a></li>
                <li><a href="#artists">artists</a></li>
                <li><a href="#gallery">Gallery</a></li>
                <li><a href="#join">Join</a></li>
                <li><a href="#map">Location</a></li>
                <li><a>Log in</a></li>
            </ul>
        </div>
      </nav>
-->
<!--          social media buttons-->
          
          <div class="home-page" id="home" onclick="closeNav();">
          </div>
          <div class="artists-page" id="artists">
             <div class="sliders">
  <!-- slides -->
  <div class="sliders__slides" onclick="closeNav();">
    <div class="slides s--active">
      <div class="slides__inner">
      </div>
    </div>
      <div class="slides">
      <div class="slides__inner">
      </div>
    </div>
      <div class="slides">
      <div class="slides__inner">
      </div>
    </div>
      <div class="slides">
      <div class="slides__inner">
      </div>
    </div>
    <div class="slides">
      <div class="slides__inner">
      </div>
    </div>
    <div class="slides">
      <div class="slides__inner">
      </div>
    </div>
    <div class="slides s--prev">
      <div class="slides__inner">
      </div>
    </div>
  </div>
  <!-- slides end -->
  <div class="sliders__control">
    <div class="sliders__control-line"></div>
    <div class="sliders__control-line"></div>
  </div>
  <div class="sliders__control sliders__control--right m--right">
    <div class="sliders__control-line"></div>
    <div class="sliders__control-line"></div>
  </div>
</div>
</div>
          </div>
          <div class="gallery-page" id="gallery" onclick="closeNav();">
              <h1>Gallery</h1>
              <div class="slider">
        <div class="slide" ><img src="images/1.jpg" /><p>rutrum tellus a tempus :)</p></div>
        <div class="slide"><img src="images/2.jpg" /><p>litora torquent per conubia</p></div>
        <div class="slide"><img src="images/2a.jpg" /><p>sed consectetur faucibus</p></div>
        <div class="slide" ><img src="images/3.jpg" /><p>eleifend tempus justo</p></div>
    </div>
<!--
              <div class="video-Block">
			<video autoplay loop muted>
				<source src="video/video1.mp4" type="video/mp4">
			  Your browser does not support HTML5 video.
			</video>
-->
              </div>
          <div class="join-page" id="join" onclick="closeNav();">
              <div class="centered-view">
              <div class="schedule">
                  <img src="images/shedule.png">
              </div>
                  <div class="text">We have sad news for you. Music is dead, and RHYTHM IS IN! Why not discover the excitement of the science of rhythm itself at “The Rhythmic Place” the home of rhythm! Thanks to the science of rhythm you don’t need musical talent to feel the rhythm, just listen. I felt the rhythm just by moving my hips! Rhythm is the new wave! Why work hard on difficult dance moves when rhythm can make you feel better than you ever dreamed of? You would be the hit of the festival! 
Remember, you don’t know you are a dancer until you feel the rhythm!
</div>
              <button class="button"><a style="text-decoration: none; color: bisque;" href="form.html">JOIN NOW!</a></button>
              </div>
          </div>
          <div class="map-page" id="map" onclick="closeNav();">
              <iframe src="https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d77148.90479841072!2d6.7132577!3d52.824107!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x47b7e010cfe19b33%3A0xe1bd06427483d7af!2sMolecaten+Park+Kuierpad!5e0!3m2!1sen!2snl!4v1510324790930" frameborder="0" style="border:0" allowfullscreen onclick="closeNav();"></iframe>
          </div>
      
      <!--footer-->
      
          <footer id="myFooter" onclick="closeNav();">
        <div class="container-footer">
            <div class="row">
                <div class="col-sm-2">
                    <ul>
                        <li><img id="wide" src="images/TM.png"></li>
                        <li><img src="images/SR.jpg"></li>
                        <li><img src="images/WM2.png"></li>
                        <li><img src="images/SHAZ.png"></li>
                        <li><img src="images/SPOT.png"></li>
                    </ul>
                </div>
        </div>
        
        </div>
              <div class="footer-copyright">
                  <p>Hosted by Fontys</p><p> Website by ISOE Fontys </p>
        </div>
    </footer>
      <script src="script/jquery-3.2.1.min.js"></script>
      <script src="script/javascript.js"></script>
  </body>
</html>