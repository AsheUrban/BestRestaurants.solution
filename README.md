Feature branch many to many relationships being set up 
Main branch is the one to many relationship

On feature branch we are hoping to impliment a relationship between the Diner and the Restaurant so that diners can create wish lists of places they'd like to try.

Things currently BUGGING me:
* _Spacing between forms and fields needs to be standardized._
* _Would love to add a date picker that would work for a birthdate as well as for implementing a reservation object._
* _Want a background image._
* _Add ActionLink to restaurant list on Cuisine details._

A few things I LEARNED:
* _Name your join table after the tables you're joining. No seriously. We tried to make this a "usuable object" for the Diner, but you end up creating a Diner every time you associate a Cuisine and a Restaurant. Keep join tables separate for the most part, anyway._

Order of opp for UPDATES:
* _Add property to model.cs_
* _Check context and factory for any related references_
* _Create required view_
* _Update any views that need to reference it (ie Home page)_
* _Create/update controller_