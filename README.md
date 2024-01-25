# The Library

## Background
My wife and I have a LOT of books, and it has become rather difficult to keep track of what we already have versus that for which we are still looking. This problem is further exacerbated by the fact that we usually shop at used book stores in our area, which don't always have all volumes in a series. To a lesser extent, this is also true of movies/music/other media. Admittedly, all this can be tracked with a (rather large, in our case) spreadsheet, but I'm a software developer looking to gain more experience in making full-stack applications, so I'm going to over-complicate this solution. 

Okay, this is only partly true. In reality, I'd like to keep track of more metadata that would get to be a little unwieldy with a spreadsheet, so this is the better solution - just probably not worth the time and effort *solely* as a solution to the problem I've described. Mostly, it's just for fun.

## Summary

The goal of this project is to create a cross-platform application capable of tracking information related to books/movies/any form of media accessible by a person. This would include a "checkout" system similar to that of a library's system - including the concept of an inter-library loan (that is, the ability to borrow an entry from someone else).

## Roadmap

1. Establish basic data structures for checking out books all in memory.
2. Establish a storage method (e.g. csv file, database, etc.) for making the entries persistent, as well as an interface for said storage.
3. Add in movies, games, music, etc.
4. Add in barcode number support.
5. Add in scanning support.
6. Allow for custom-defined entry-types.
7. ???

## Current Status

Very, very immature. Currently, I am still in the process of creating some of the initial versions of the basic data types to be used throughout the project (i.e. step 1 of the roadmap).