---
title: deck
layout: default
---
<ul>
{% for channel in channels.entries %}
<li><a href="{{ channel.url | prepend: site.url }}">{{ channel.title }}</a></li>
{% endfor %}
</ul>