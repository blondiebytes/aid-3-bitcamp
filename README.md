# BumbleAidr : bitcamp

## Idea
A therapeutic vr game to diagnose and treat patients with ADD. 

## Inspiration
Less than 1 in 3 children with ADD receive both medication treatment and behavior therapy, the preferred treatment approach for children ages 6 and older. Symptoms of ADD typically first appear between the ages of 3 and 6, which means we have the opportunity to detect it early, but the disorder often goes undiscovered and untreated. What if emerging virtual reality technology could change this? Most schools have eye exams to screen students for vision problems, but there's nothing provided to detect behavioral disorders like ADD. Meet BumbleAidr - providing an easy way to identify ADD in students as well as a therapeutic treatment plan.

## What it does
BumbleAidr is a therapeutic VR game to diagnose and treat patients with ADD. Integrating Oculus into Unity, our virtual reality exercise focuses on concentration, having the user press a button when an item is out of place. Throughout the gameplay, the user is met with both visual and aural distractions. Using the Oculus' APIs and eye-tracking, we can detect how distracted the user is at a given time, which can then be measured to identify ADD. Using the Muse headband, we can also detect the patient's brainwaves throughout the game and see how distraction effect them. Data gathered from the game is sent to a server and graphed beautifully onto a website, which can be accessed by a doctor and the patient's loved ones. The website was made with HTML5, CSS, Bootstrap, JQuery, JavaScript, Node.js, Hapi.js, MongoDB, and Mongoose. We also used the SparkPost API to make it easier to send blind-confidential information between the patient's parents and the doctor. 

## Challenges we ran into
Time - messing with the new consumer VR and installing the appropriate software took quite a while - almost half of the hackathon time.

## What this means?
BumbleAidr cannot only help with early-detection of ADD, but can also help patients improve their concentration. By practicing with the virtual reality games, ADD patients can use BumbleAidr as a therapeutic treatment program and better their overall focus overtime.

## Built with
Muse, unity, html5, css, jquery, javascript, C3, node.js, hapi.js, mongodb, mongoose, bootstrap, sparkpost-api, azure, oculus-cv1

# More
See devpost (http://devpost.com/software/bumbleaidr)
