# Nudge Box API

## Purpose
Imagine an app that lets you make your own "magic 8 ball" or "ingredient mystery box" like they have on Masterchef. Imagine you can use that very same app to make lists of songs, movies, things you still want to learn, bucket list items, a simple to-do list, your own _Pictionary_ or _30 Seconds_ prompts and more. Well, this is nudge box in a nutshell!

## How Nudge Box works
_(...or will work, eventually, when everything's coded ;-))_

### Nudge Box Hierarchy

#### 1. Prompts
This is the lowest "level" of our hierarchy.
Let's take the magic 8 ball and the ingredient mystery box as an example again.
The magic 8 ball may come with a few `Prompt` items such as `maybe...`, `Go for it!` and `I'd rather not say.`.
The ingredient mystery box also has prompts, but they will look different: A `Prompt` here might be `Potato`, `Lemon Juice` or `Leftovers from yesterday`.

#### 2. Prompt Categories
Sometimes it's necessary to nest prompts into categories, while still being part of the same list/game/box. Let's take this example: say you want to create an ingredient mystery box, but you wish to only include prompts of a certain type, or maybe even just the generalised category as a prompt. In other words, let's say you have a `Valentines` category, a `Red` category and a `Vegetables` category, and this time around you only wish to have prompts picked from the `Valentines` and `Red` categories, then this is something you can do with the `Category` type.

#### 3. Nudge Boxes
Now, you don't want all your prompts and categories floating around in space and have someone get "Lemon Juice" when they actually wanted a random song title. This is why we have our third level, which is the `NudgeBox`. You can create as many nudge boxes as you like (and the server has space for ;-)). Your categories and prompts will live in nudge boxes and you can even share prompts and categories among different nudge boxes if they apply, so that you don't have to rewrite anything.

### Your Profile
Your profile comes in handy so that you can have an overview of all your nudge boxes and their sub-categories and prompts.
Here you can adminster all of them - be it create, delete, update, and list them.

### Settings
This is where the fun part begins!
In your profile, you'll find settings. You'll also notice that you can apply settings across the board or to individual nudge boxes.

#### Randomization Settings
You have the following randomization settings available to you that will determine which "nudge" will be returned.

- `remember me` toggle: unlike _Spotify_ ;-), this thing will actually allow you to control what you've already seen, so that seen prompts are not shown again (at least until all your prompts have been shown)
- `not random`: yes, there are a few not so random options too for those who like things structured, or at times when you need to do things in order.
	- `FIFO`: first in, first out. Just like a queue is supposed to work ;-)
	- `LIFO`: last in, first out. Like when you're grabbing a plate out of your cupboard. Or jumping the queue at Home Affairs...
	- `Custom Order`: there are a few custom ordering options available. You can add as many options to your prompts as you wish, and order any of them as long as their type is sortable. E.g. a date or time can be sorted, and so can a word (alphabetically) or a number (from small to large or vice versa). There's even a tiny "preview" that shows you how your prompts will be presented to the user of the nudge box, so that you can be absolutely sure the ordering is as intended.
- for the nerds and geeks:
	- `upload` a randomization algorithm: yes, you heard me right. And if you're a hacker reading this - I crossed my T's and dotted my I's, so don't try injecting anything weird, alright?
	- or choose from various existing randomization algorithms
		- weighted probability distribution
		- reservoir sampling
		- 
- 

#### Visualization Settings
Ooooh goody, I love this part.
Choose how you want your nudge box to be presented:
- `spin a wheel`: a big spinning wheel on your screen that will randomly stop at a prompt. This is available as long as your chosen randomization algorithm allows it.
- `billboard style`: have only the prompt displayed in big text across the entire screen. This style can also be slightly edited: you can change the background image or effect, as well as style the text. You can also choose from a few animation options, like a "fly in" effect etc.
- `advent calendar style`: your prompts can be hidden behind little doors, like an advent calendar
- `prompt listing`: set how many prompts you wish to have displayed to the user at the same time. These will then be listed as options one after the other. You can also choose from which and how many categories you wish to have your prompts listed. This option will allow you to add a description too: for example, imagine you are a coding tutor and you want to give your student 5 prompts simultaneously, but you want to inform them that they can use any 3 of the 5. Another example is you're a teacher and want to display some random essay options to your students. Then you can add a description saying that they should choose 1 prompt as inspiration for their essay.
- `mystery box style`: hide your prompt under a box that has been turned upside down. When the box is lifted, the prompt appears. If you added an option to your prompt such as an image, you can even make the image of the prompt appear instead of the text (or both). This option will also allow you to choose how many prompts or prompt categories you wish to display simultaneously. If you play with judges, you can also set whether to display them.
- `roll the dice`: choose from 1 die to as many dice as you need, and watch them rolling on your screen. Each die represents a category, and the number of prompts you have in your category determines the shape of your die. Think _Dungeons and Dragons_ style where you suddenly have a D20 that contains 20 of your prompts. You can also limit your dice to a certain number of faces, so that a maximum number of prompts are always displayed on your dice.
- `custom`: upload your own HTML, CSS and JS to make this completely unique to you and your imagination. For instance, if you wanted to you could upload some logic to create a virtual roulette table or bingo setup. 

#### Sharing Settings
Fun is meant to be shared, right?
You can either export your nudge box into its own little app, or you can allow someone to play online by sharing  your nudge box with them. Multiple options are available: send them an email, a whatsapp, post to social, copy a link etc. Your nudge box will only be visible to those you choose to share it with (or in case of the link: those who have the link). You can also manage who you shared nudge boxes with or set an expiry date.
Note that when sharing a nudge box over the internet, the app needs to facilitate the connection between the consumer and the nudge box. Hence, you will be prompted to say that you understand your data will no longer be available just locally if this was the case before.

#### Privacy Settings

##### Authentication and authorization to get to your profile
You'll have to log in so that nobody unauthorized can create nudge boxes on your behalf.

##### Access code for nudge boxes
You can choose to add an access code to a nudge box, so that when you share it, those who wish to use it need to provide that code first.

##### Self-hosted versus cloud
Self-hosted is the default option:
If you don't want your nudges to land on our servers, you can choose to run the app completely independently on your device. Your data will be stored in a local database. Just a note that we won't be liable for data loss; unless it was a bug on our side.
- Cloud:
If you want your data to be stored on our servers, choose this option. Limited backup & export options will then be available to you.
- Backup to my cloud:
Integrate with your Google Drive or Microsoft OneDrive and save local data onto your cloud storage every now and then by means of just a few clicks.

##### Encryption
Choose to have your prompts stored in an encrypted fashion. This could be particularly useful if you need to store things in the cloud.

#### Other Settings

##### Spell Checker
Choose to spell check the prompts you write. This will also help with translating them later on if you wish to view your prompts in multiple languages.

##### Enable the Pantry
If you have ever watched MasterChef, you may have a good idea of what this is: a pantry is a list of prompts that your user can take from at will, along with the prompt they were just given. If you enable the pantry, you can create a separate list of prompts that can be accessed by the user. You can connect pantries to nudge boxes just as it makes sense to you. You can even choose another nudge box or category as a pantry.

##### When to view the next prompt
There are a few settings that allow you to set when you want the next prompt to be presented to you:
- `On page load` (default) - whenever you refresh the page or visit your link again, a new prompt will be displayed
- `Timed` - you'll be able to set a time in seconds, minutes, hours, days or years which will determine when to refresh your prompt. You can also choose `random time` here - this makes it very interesting for games like when loot becomes available or treasures are found.
- `Upon upload` - when a user has uploaded something related to the prompt, they can see the next prompt.
- `Upon button click` - the user clicks a button and voila, a new prompt appears. You can customize what the button says: e.g. "completed", or "next". You also have some button styling options and nice sounds to choose from.

### Mobile App
The app is available in a mobile version. Yay!
Note that depending on whether you've chosen local storage or cloud, you may have differing experiences between devices. For local storage, there is a sync option as well though - but note that for this to work your data will travel across the world wide web.

### Nudge Box Features For Educational Use

#### Special Upload Feature
Go to your settings and enable the upload feature. This allows those you share your nudge box with to upload something they made based on the prompt given to them. You can choose to get a notification when this happens: be it a ping to your phone or an email. 
_Another note for the hackers: don't get too excited; I've also done my validation due diligence here!_

##### Judging an uploaded item
Say you need to judge the uploaded content based on a prompt in some way: you need to give the submitted work a rating or score. We make this possible for you and even add in a little bit of fun!

##### Meet the judges
You can set up a panel of judges that will score the work; this could be merely for fun or as advanced as a real person. You'll have a few customization settings to play with: create or upload an avatar or use the power of AI to generate something, add names, descriptions, roles, personalities and more. You'll also be able to set which nudge boxes you wish to add your panel of judges to. And guess what: even their opinions of the "work" that has been presented to them can be randomized to a wide extent, and there is some clever intelligence behind it too if you wish to use it.

###### Special Guest Judge
Yes, you can have a special guest judge configured too that can show up at random or for certain occasions or users.

### Nudge Box Features for boosting Social Media Presence

#### Post prompt to social
What if you want to create a nudge box that posts a prompt onto your Instagram feed every day for your followers to see? The API makes this extremely easy for you. Here, you also have some customization options like adding your branding, uploading a custom background, letting AI do its magic, or, you guessed it, randomizing it if you're brave enough.

### Language Support
Say you want to play your _30 Seconds_ style game that you created on Nudge Box with your English friends this weekend and with your Afrikaans in-laws the weekend after that. And then there's your German family who you may want to play it with once a year. That's no problem either! Choose the language in which you want to play and your prompts will be translated. (note that with the help of AI it will try its best to find the right word and the right context, but computers can make mistakes!)

### Pre-Loaded Lists
Sometimes you wish to have a list of letters in the alphabet or numbers from 1 to `x`. Instead of having to type in prompts for all of these, we have some pre-defined list options available for you that you can choose from.

## Examples
Here are some real life examples to give you an idea of how powerful Nudge Box can be.

### As a clever to-do list
_to be continued..._

### As a coding prompt mystery box generator
_to be continued..._

### As a "what to eat" cheat sheet
_to be continued..._

### As table prayer dice
_to be continued..._

### As a plain old die
_to be continued..._