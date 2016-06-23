# Umbraco Ditto Abstract IPublishedContent processors

This is a proof of concept Umbraco app which attempts to map a concrete class to a potentially abstract class or interface.

Whether it be a single IPublishedContent or IEnumerable<IPublishedContent>.

The reason for chosing these types is because the Umbraco package Ditto works best with these types. Other popular packages such as Archetype & Nested Content also play nicely with this Umbraco.Core standard interface making it an ideal choice for converting content.

##What's included

A setup Umbraco instance with a Document Type preloaded with content and media.

backoffice credentials: admin@admin.com / password

### Media credits:

* Image: https://placeholdit.imgix.net/~text?txtsize=47&txt=500%C3%97200&w=500&h=200&fm=png
* Video: http://www.sample-videos.com/index.php#sample-mp4-video

### Code navigation

Wiring logic in HomePageController.cs

ViewModel classes contain the POCO setup

ComponentModel has all the custom Ditto processors

A single helper classes: TypeHelper for getting a class from an IEnumerable<T>.

A single service class for sharing logic between Abstract IPublishedContent & IEnumerable<IPublishedContent> processors.

Also included: ArchetypeModel processor and other processors which are simply for helping setup the demo app.


### How the processors works

Add AbstractIPublishedContentMetaDataAttribute to you concrete class, ensure it has the correct type which is assignable or implements the original property type.

Add AbstractIPublishedContent to your POCO which will be on an abstract type or interface. Alternatively using AbstractIPublishedContentCollection with a IEnumerable<T> property for mapping a collection of IEnumerable<IPublishedContent>.


### nuget packages

* Umbraco CMS v7.5.0 - beta
* Umbraco Ditto v0.9.0
* nuPickers
* Archetype v1.13.0
