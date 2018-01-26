/* Copyright (c) Nishit Tated. All Rights Reserved.
   project name: College Alumni System
  This project is licensed under the MIT license, see LICENSE. */
$( document ).ready(function() {
  var userInput = $('#username-input'),
      userWrap = $('.username-wrap'),
      user = $('#name');

  userInput.keyup(function (event) {
      if (event.which == 13) {
        var name = $(this).val();
        user.text(name);
        userInput.addClass('hidden');
         userWrap.addClass('hidden');
        user.removeClass('hidden');
        user.parent().addClass('pw-active');
        $('.password').focus();
        return false; 
      }
  });
  
  user.click(function (event) {
        user.addClass('hidden');
        user.parent().removeClass('pw-active'); 
        userInput.removeClass('hidden');
     userWrap.removeClass('hidden');
  });
});
