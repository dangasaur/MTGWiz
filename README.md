# MTGWiz
TCG Automation Suite

## How To Build

This project requires EMGU CV 3.1 to build.

## TODO

### process
- phash interface and impl, image goes in and phash comes out, see [Looks Like It](http://www.hackerfactor.com/blog/?/archives/432-Looks-Like-It.html)
- MTG card struct/class
- interface for card backend with static or primitive implementation for several cards or single set
- interface to pull images from web
- configuration for image puller to restrict on set, other attributes
- what to do with rejection

### UI
- figure out MVC for c# Windows Forms
- UI mockup for output with debugging, show each step of image transformation ie. source -> resize -> blur -> recolor -> binary hash
- input UI mockup for webcam w/ webcam selector
- input UI mockup for selected image(s)

### collection output
- collection interface with basic impl to file
- collection impl to some public web api
