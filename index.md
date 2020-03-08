---
title: deck
layout: default
---
{% for channel in channels.entries %}
<a href="{{ channel.url | prepend: site.url }}">{{ channel.title }}</a>
{% endfor %}
