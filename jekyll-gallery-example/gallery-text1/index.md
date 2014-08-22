---
layout: default
title: Gallery with text (version 1)
imgfolder: /img/demopage
images:
  - name: image-1.jpg
    thumb: thumb-1.jpg
    text: The first image
  - name: image-2.jpg
    thumb: thumb-2.jpg
    text: The second image
  - name: image-3.jpg
    thumb: thumb-3.jpg
    text: The third image
---

{% include galheader.html %}

Some text here...and then, all the images in one single gallery:

{% include gal.html %}

...and more text after the gallery
