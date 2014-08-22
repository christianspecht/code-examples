---
layout: default
title: Gallery with text (version 2)
imgfolder: /img/demopage
images:
  - name: image-4.jpg
    thumb: thumb-4.jpg
    text: The 4th image
  - name: image-5.jpg
    thumb: thumb-5.jpg
    text: The 5th image
  - name: image-6.jpg
    thumb: thumb-6.jpg
    text: The 6th image
---

{% include galheader.html %}

Some text here, then two images:

{% include gal.html image="image-4.jpg" %}
{% include gal.html image="image-5.jpg" %}

...and more text...

Even more text and the last image:

{% include gal.html image="image-6.jpg" %}

Some text at the end
