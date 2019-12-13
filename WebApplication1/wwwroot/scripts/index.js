/*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
ACCORDION | ACCORDION | ACCORDION 
ACCORDION | ACCORDION | ACCORDION 
ACCORDION | ACCORDION | ACCORDION 
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*/

var acc = document.getElementsByClassName("accordion");
var i;
var removeCounter = 1;

for (i = 0; i < acc.length; i++) {
    acc[i].addEventListener("click", function() {
        /* Toggle between adding and removing the "active" class,
        to highlight the button that controls the panel */
        this.classList.toggle("active");

        /* Toggle between hiding and showing the active panel */
        var panel = this.nextElementSibling;
        if (panel.style.display === "block") {
            panel.style.display = "none";
        } else {
            panel.style.display = "block";
        }
    });
}
/*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
SLIDER | SLIDER | SLIDER | SLIDER 
SLIDER | SLIDER | SLIDER | SLIDER
SLIDER | SLIDER | SLIDER | SLIDER
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*/

'use strict';

var cardContainer = document.querySelector('.visual');
var allCards = document.querySelectorAll('.card');
var nope = document.getElementById('nope');
var love = document.getElementById('love');

/*initCards kigger på alle kort uden .removed for at fremvise alle kort ikke er blevet fjernet*/
function initCards(card, index) {
    var newCards = document.querySelectorAll('.card:not(.removed)');

    newCards.forEach(function(card, index) {
        card.style.zIndex = allCards.length - index;
        card.style.transform = 'scale(' + (10 - index) / 10 + ') translateY(-' + 15 * index + 'px)';
        card.style.opacity = (10 - index) / 10;
    });
    cardContainer.classList.add('loaded');

    //Finder det øverste kort for at fremvise information om det relevante sted, som ellers er blevet sjult med en display none i css
    let topCard = newCards[0];
    let topInfo = topCard.parentElement.querySelector('.info');
    if (topInfo) {
        topInfo.style.display = "block";
    };

}
//kører den som det første
initCards();

// Functioner ifht. pan functionerne. og efterfølgende handling 
allCards.forEach(function(el) {
    var hammertime = new Hammer(el);

    //in movement
    hammertime.on('pan', function(event) {
        el.classList.add('moving');
    });

    hammertime.on('pan', function(event) {
        if (event.deltaX === 0) return;
        if (event.center.x === 0 && event.center.y === 0) return;

        var xMulti = event.deltaX * 0.03;
        var yMulti = event.deltaY / 80;
        var rotate = xMulti * yMulti;

        event.target.style.transform = 'translate(' + event.deltaX + 'px, ' + event.deltaY + 'px) rotate(' + rotate + 'deg)';
    });

    //når mevement er stoppet
    hammertime.on('panend', function(event) {
        el.classList.remove('moving');

        var moveOutWidth = document.body.clientWidth;
        var keep = Math.abs(event.deltaX) < 80 || Math.abs(event.velocityX) < 0.5;

        event.target.classList.toggle('removed', !keep);

        if (keep) {
            event.target.style.transform = '';
        } else {
            var endX = Math.max(Math.abs(event.velocityX) * moveOutWidth, moveOutWidth);
            var toX = event.deltaX > 0 ? endX : -endX;
            var endY = Math.abs(event.velocityY) * moveOutWidth;
            var toY = event.deltaY > 0 ? endY : -endY;
            var xMulti = event.deltaX * 0.03;
            var yMulti = event.deltaY / 80;
            var rotate = xMulti * yMulti;

            event.target.style.transform = 'translate(' + toX + 'px, ' + (toY + event.deltaY) + 'px) rotate(' + rotate + 'deg)';
            //kørers af igen, med den removed class der nu er tilføjet kommer det fjernet kort ikke med i denne omgang 
            initCards();
            //For at skjule den forrige restaurants informationer, har tilføjes en hide class, som har display: none
            event.target.parentNode.querySelector(".info").classList.add("hide");
        }
    });
});

//Knappernes funktion 
function createButtonListener(love) {
    return function (event) {
        var cards = document.querySelectorAll('.card:not(.removed)');
        var moveOutWidth = document.body.clientWidth * 1.5;

        if (!cards.length) return false;

        var card = cards[0];

        card.classList.add('removed');

        if (love) {
            card.style.transform = 'translate(' + moveOutWidth + 'px, -100px) rotate(-30deg)';
            card.parentNode.querySelector(".info").classList.add("hide");
            window.scrollTo(0, 0);
        } else {
            card.style.transform = 'translate(-' + moveOutWidth + 'px, -100px) rotate(30deg)';
            card.parentNode.querySelector(".info").classList.add("hide");
            window.scrollTo(0, 0);
        }

        //Igen da de får tilføjet en removed class kommer den ikke med i den nye initCards
        initCards();

        event.preventDefault();
    };
}

var nopeListener = createButtonListener(false);
var loveListener = createButtonListener(true);

nope.addEventListener('click', nopeListener);
love.addEventListener('click', loveListener);


/*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
Remove menu item with 0 dkk cost
Remove menu item with 0 dkk cost
Remove menu item with 0 dkk cost
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*/

// Get all the elements.
var elements = document.querySelectorAll(".price");
// Iterate each.
for (var i = 0; i < elements.length; i++) {
    // Check if the text is found.
    if (elements[i].innerHTML == "0,00 DKK")
        // Replace the contents.
        elements[i].innerHTML = elements[i].innerHTML.replace('0,00 DKK', '');
}