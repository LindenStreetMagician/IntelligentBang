# IntelligentBang 🔫

<p align="center">
    <img src="Readme/intelligentbang.gif"/>
</p>

## The Context
I'm a member of one of the *Semmelweis University - Medicine and health sciences, Budapest* communities and as a member of this community we organize trainings each year for the newcomers if they wish to join us.

They are attending to trainings in groups of 30+ over several weeks. Where we teach them useful soft skills and we are also building them into a team.

## The Problem

Usually these training are weekly and in person, but ... this particular training took place in 2021 ... during the pandemic ... so we were forced to do it online.

One of the games we like to play on the first 2 trainings is called "Bang!" as an icebreaker/name learning game. People must stand in a circle facing inwards and there is one person in the middle who is conducting the game.

The rules are:
* The person in the middle points at random people in the circle.
* The person whom was pointed at must duck as fast as possible. if this person fails to duck before shots are fired the person is the one being eliminated.
* The people standing on the ducking person's each side have to yell the name of the other standing person faster along with a fingerbang gesture wins. The faster person wins round and the other one is eliminated.
* It goes on until there is only 1 left, the winner.

Rather simple game, right? Well unfortunately not online...

There is a different version from this game called **IntelligentBang** where the person standing in the middle points at a random person, but the person in the middle has to say a topic along with the pointing.

The ducking rule, the fingerbang rule stays the same, but instead of saying the other person's name they have to say something belonging to that topic.

For example the person in the middle points and yells "Capital cities!" from the contestants the one who is fingerbanging at the other with a capital city like "Budapest!" wins that round.

We were short of program ideas and I figured this could be sort of done in a quick manner.

## The Solution

So I coded up this little winforms application, I really needed to hurry so I didn't have time for a webapp. I also built this project with all it's dependencies (self-contained) so I could forward it to other groups without me having them to install .NET Runtime.

"The person in the middle" was sharing the screen the topics and names were loaded to their respective .txt files and the conducting person just had to click on the gun and names and topics were randomized and if there was a clear winner the conductor had to click the button next to the winner, the other one went to the graveyard :(.

## Further improvements

... but I really hope we will never need these, beacuse that might mean another pandemic 😬
* Introduce i18n, for now it's hard coded hungarian.
* Turn this into a webapp for fun.