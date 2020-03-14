---
title: deck
layout: default
---
<head>
  <title>{{ page.title }}</title>
  {% inc head.html %}
  {% inc firebase.html %}
  {% inc auth.html %}
</head>

<body>
<div class="user-bar">
  <div id="sign-in-status"></div>
  <div id="sign-in"></div>
  <img id="account-image" src=""></img>
  <pre id="account-details"></pre>
  <button id="create-channel" onclick="">Create channel</button>
</div>
  <ul>
  {% for channel in channels.entries %}
  <li><a href="{{ channel.url | prepend: site.url }}">{{ channel.title }}</a></li>
  {% endfor %}
  </ul>
</body>
