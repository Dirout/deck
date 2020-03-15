---
title: deck
layout: default
---
<head>
  <title>{{ page.title }}</title>
  {% inc head.html %}
</head>

<body>
<div class="user-bar">
  <a id="sign-in" href=""></div>
  <p id="sign-in-status" style="display: none;"></p>
  <p id="account-details" style="display: none;"></p>
  <p id="create-channel" style="display: none;"></p>
  <a href="{{ site.url }}/me"><img id="account-image" src=""></img></a>
  <p id="account-name"></p>
</div>
  <ul>
  {% for channel in channels.entries %}
  <li><a href="{{ channel.url | prepend: site.url }}">{{ channel.title }}</a></li>
  {% endfor %}
  </ul>
  {% inc firebase.html %}
  {% inc auth.html %}
</body>
