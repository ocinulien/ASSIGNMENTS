// Create the canvas
var canvas = document.createElement("canvas");
var ctx = canvas.getContext("2d");
canvas.width = 512;
canvas.height = 480;
document.body.appendChild(canvas);

// Load images
var imagesLoaded = 0;

var bgImage = new Image();
bgImage.onload = checkImagesLoaded;
bgImage.src = "background.png";

var monsterImage = new Image();
monsterImage.onload = checkImagesLoaded;
monsterImage.src = "monster.png"; 

// Game objects
var monster = {
    x: 0,
    y: 0
};

var monstersCaught = 0;
var jumpingInterval = 1000; // Initial interval in milliseconds

var jumpingTimer; // To control the jumping interval

function checkImagesLoaded() {
    imagesLoaded++;
    if (imagesLoaded === 2) {
        reset();
        main();
    }
}

// Reset the game
function reset() {
    monster.x = 32 + Math.random() * (canvas.width - 64);
    monster.y = 32 + Math.random() * (canvas.height - 64);
    clearInterval(jumpingTimer); // Clear any previous interval
    jumpingTimer = setInterval(moveMonster, jumpingInterval);
}

// Reset the score
function resetScore() {
    monstersCaught = 0;
}

// Reset the speed
function resetSpeed() {
    jumpingInterval = 1000;
    clearInterval(jumpingTimer);
    jumpingTimer = setInterval(moveMonster, jumpingInterval);
}

// Move the monster to a new random position
function moveMonster() {
    monster.x = 32 + Math.random() * (canvas.width - 64);
    monster.y = 32 + Math.random() * (canvas.height - 64);
}

// Handle mouse click on monster
canvas.addEventListener("click", function (event) {
    var mouseX = event.clientX - canvas.getBoundingClientRect().left;
    var mouseY = event.clientY - canvas.getBoundingClientRect().top;

    if (
        monster.x <= mouseX &&
        mouseX <= monster.x + 32 &&
        monster.y <= mouseY &&
        mouseY <= monster.y + 32
    ) {
        monstersCaught++;
        reset();
        jumpingInterval -= 50; // Decrease the interval by 50 milliseconds
        if (jumpingInterval < 0) {
            jumpingInterval = 0; // Ensure the interval doesn't become negative
        }
    }
});

// Draw everything
function render() {
    ctx.drawImage(bgImage, 0, 0);
    ctx.drawImage(monsterImage, monster.x, monster.y);

    ctx.fillStyle = "rgb(250, 250, 250)";
    ctx.font = "24px Helvetica";
    ctx.textAlign = "left";
    ctx.textBaseline = "top";
    ctx.fillText("Monsters caught: " + monstersCaught, 32, 32);
    ctx.fillText("Jumping Interval: " + jumpingInterval + " ms", 32, 64);
}

// The main game loop
function main() {
    render();
    requestAnimationFrame(main);
}

// Cross-browser support for requestAnimationFrame
var w = window;
requestAnimationFrame =
    w.requestAnimationFrame ||
    w.webkitRequestAnimationFrame ||
    w.msRequestAnimationFrame ||
    w.mozRequestAnimationFrame;

// Let's play this game!
reset();

// Add event listener for the reset score button
var resetScoreButton = document.getElementById("resetScoreButton");
resetScoreButton.addEventListener("click", resetScore);

// Add event listener for the reset speed button
var resetSpeedButton = document.getElementById("resetSpeedButton");
resetSpeedButton.addEventListener("click", resetSpeed);
