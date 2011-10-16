######################################################
##
##  Webscape:
##
##  A game about the internet.
##  For the first CogNation Game Jam, themed 'Tedium'.
##
##  John Earnest
##
######################################################

:include "../Grid.fs"
:include "../Sprites.fs"
:include "../String.fs"
:include "../Util.fs"
:include "../Print.fs"

:image sprite-tiles "sites.png" 64 64
:image grid-tiles "net.png" 8 8
:data grid

	  2   3   3   3   3   3   3   3   3   3 128 151 165 162 179 163 161 176 165 128 151 165 162 169 167 161 180 175 178 128   3   3   3   3   3   3   3   3   3   4  -1 
	  5   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   6  -1 
	  5   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   6  -1 
	  5   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   6  -1 
	  5   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   6  -1 
	  5   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   6  -1 
	  5   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   6  -1 
	  5  32  98  99  99  99  99  99  99  99  99 100  32  32  32  98  99  99  99  99  99  99  99  99 100  32  32  32  98  99  99  99  99  99  99  99  99 100  32   6  -1 
	  5  32 101   0  32   0  32   0  32   0  32 102  32  32  32 101   0  32   0  32   0  32   0  32 102  32  32  32 101   0  32   0  32   0  32   0  32 102  32   6  -1 
	  5  32 101  32   0  32   0  32   0  32   0 102  32  32  32 101  32   0  32   0  32   0  32   0 102  32  32  32 101  32   0  32   0  32   0  32   0 102  32   6  -1 
	  5  32 101   0  32   0  32   0  32   0  32 102  32  32  32 101   0  32   0  32   0  32   0  32 102  32  32  32 101   0  32   0  32   0  32   0  32 102  32   6  -1 
	  5  32 101  32   0  32   0  32   0  32   0 102  32  32  32 101  32   0  32   0  32   0  32   0 102  32  32  32 101  32   0  32   0  32   0  32   0 102  32   6  -1 
	  5  32 101   0  32   0  32   0  32   0  32 102  32  32  32 101   0  32   0  32   0  32   0  32 102  32  32  32 101   0  32   0  32   0  32   0  32 102  32   6  -1 
	  5  32 101  32   0  32   0  32   0  32   0 102  32  32  32 101  32   0  32   0  32   0  32   0 102  32  32  32 101  32   0  32   0  32   0  32   0 102  32   6  -1 
	  5  32 101   0  32   0  32   0  32   0  32 102  32  32  32 101   0  32   0  32   0  32   0  32 102  32  32  32 101   0  32   0  32   0  32   0  32 102  32   6  -1 
	  5  32 101  32   0  32   0  32   0  32   0 102  32  32  32 101  32   0  32   0  32   0  32   0 102  32  32  32 101  32   0  32   0  32   0  32   0 102  32   6  -1 
	  5  32 103 104 104 104 104 104 104 104 104 105  32  32  32 103 104 104 104 104 104 104 104 104 105  32  32  32 103 104 104 104 104 104 104 104 104 105  32   6  -1 
	  5   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   6  -1 
	  5   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   6  -1 
	  5   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   6  -1 
	  5   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   6  -1 
	  5   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   6  -1 
	  5   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   6  -1 
	  5   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   6  -1 
	  5   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   6  -1 
	  5   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   0   6  -1 
	  8   9   9   9   9   9   9   9   9   9   9   9   9   9   9   9   9   9   9   9   9   9   9   9   9   9   9   9   9   9   9   9   9   9   9   9   9   9   9  10  -1 
	128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128  -1 
	128  96  96 122  96  96  96  96  96  96  96  96  96  96  96  96  96  96  96  96  96  96  96  96  96  96  96  96  96  96  96  96  96  96  96 163 178 165 164 128  -1 
	128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128 128  -1 
	 -1  -1  -1  -1  -1  -1  -1  -1  -1  -1  -1  -1  -1  -1  -1  -1  -1  -1  -1  -1  -1  -1  -1  -1  -1  -1  -1  -1  -1  -1  -1  -1  -1  -1  -1  -1  -1  -1  -1  -1  -1 

:string name1 "   Cats.com"
:string name2 " TaterPRO.ORG"
:string name3 "  Wikiphilia"
:string name4 "  TETRIS.XXX"
:string name5 "FanFiction.net"
:string name6 "NewGrounds.com"
:string name7 "    MTU.edu"
:string name8 " CogNation.org"

:data diffs 1     3     1     1     2     1     1     2
:data names name1 name2 name3 name4 name5 name6 name7 name8
:const namecount 8

:string b1 "  POST      "
:string b2 "  REFRESH   "
:string b3 "  MODERATE  "
:data button-labels b1 b2 b3
:const buttoncount 3

:string mar0 "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
:string mar1 "Cats, Cats and more Cats! The official online home of anybody who Loooves cats! "
:string mar2 "Red Potatoes Russet Potatoes Mashed Potatoes Yukon Gold Potatoes POTATOOOOOES.  "
:string mar3 "Wikiphilia: The Consent-Free Online Encyclopedia anyone can edit.       Anyone. "
:string mar4 "Hot piece on piece action! Finish your line! FROM RUSSIA, WITH LOVEMAKING. XXX! "
:string mar5 "John Reciprocating waited. There were vaccuums here, he was sure of it.         "
:string mar6 "Columbian or Brazillian? Find out once and for all in a new special editorial.  "
:string mar7 "Temperature: Cold            Special Events:                                    "
:string mar8 "Main theme: Tedium        Special Bonus Theme: The Michigan Tech Experience     "
:data marquees mar1 mar2 mar3 mar4 mar5 mar6 mar7 mar8

:array posts   8 0 # how many posts were made since last refresh?
:array myposts 8 0 # have I made a post here?

:var site
:var mar
:var mart
:var button
:var cred
:var minutes
:var seconds
:var sect

##############################################
#
# utility routines that should be elsewhere:
#
##############################################
: draw-number (x y n -- )
	>r
	loop
		2dup tile-grid@ i 10 mod 112 + swap ! # draw digit
		swap 1 - swap                         # move cursor
		r> 10 / >r i                          # cast out digits
	while
	2drop r> drop
;

:data ascii -32
: grid-type (x y addr -- )
	>r tile-grid@ r> swap
	loop
		(string grid)
		over @ ascii @ + over !
		swap 1 + swap 1 +
		over @
	while
	2drop
;

: light-text -32 ascii ! ;
: dark-text   64 ascii ! ;

: wait
	loop keys key-a and -if break then sync again
	loop keys key-a and  if break then sync again
	loop keys key-a and -if break then sync again
;

##############################################
#
# time management
#
##############################################
: timesup
	seconds @ 0 <=
	minutes @ 0 <=
	and
;

: draw-time
	1 28 tile-grid@ 2 112 fill
	2 28 minutes @ draw-number
	4 28 tile-grid@ 2 112 fill
	5 28 seconds @ draw-number
;

##############################################
#
# misc UI and graphics
#
##############################################

: draw-cred
	20 28 tile-grid@ 15 96 fill
	33 28 cred @ draw-number
;

: give-cred ( n -- )
	cred @ + cred !
	cred @ 0 < if 0 cred ! then
	draw-cred
;

: nextsite   site @ 1 + namecount mod ;
: prevsite   site @ 1 - namecount mod ;
: nextbutton button @ 1 + buttoncount mod ;
: prevbutton button @ 1 - buttoncount mod ;
: this-diff  site @ diffs + @ ;

: draw-sites
	64x64 prevsite  24 64 0 >sprite
	64x64 site @   128 64 1 >sprite
	64x64 nextsite 232 64 2 >sprite
	
	13 5 tile-grid@ 20 32 fill
	13 5 site @ names + @ grid-type
	
	# difficulty:
	5 for
		this-diff i > if 28 else 27 then
		15 i + 17 tile-grid@ !
	next
;

: draw-marquee
	mart inc@
	mart @ 5 > if mar @ 1 + 80 mod mar ! 0 mart ! then
	
	1 2 tile-grid@
	marquees site @ + @
	37 for
		over i +
		over mar @ i + 80 mod + @ 64 +
		swap !
	next
	2drop
;

: draw-buttons
	buttoncount 1 - for
		i button @ xor -if dark-text else light-text then
		14 21 i + i button-labels + @ grid-type
	next
	light-text
;

: erase-buttons
	7 for
		1 18 i + tile-grid@ 38 0 fill
	next
;

##############################################
#
# main game logic
#
##############################################

: clock
	# randomly distribute posts
	RN @ 100 mod 95 > if
		RN @ namecount mod
		dup posts   + inc@
		
		# if you've posted there, you get a bonus.
		dup myposts + @ if
			posts + inc@
		else
			drop
		then
	then

	draw-time
	timesup if exit then
	sect @ 1 - dup 0 > if sect ! exit then
	drop 30 sect !
	
	seconds dec@
	timesup if exit then
	seconds @ 1 < if
		minutes dec@
		59 seconds !
	then
;

: reset-game
	light-text
	
	0 site   !
	0 button !
	0 cred   !
	draw-cred
	
	 5 minutes !
	 0 seconds !
	draw-time
	
	posts   namecount 0 fill
	myposts namecount 0 fill
;

: work ( time -- )
	erase-buttons
	14 22 "WORKING." grid-type
	dup for draw-marquee clock sync next
	14 22 "WORKING.." grid-type
	dup for draw-marquee clock sync next
	14 22 "WORKING..." grid-type	
	dup for draw-marquee clock sync next
	14 22 "WORKING...." grid-type
	    for draw-marquee clock sync next
	erase-buttons
;

: message ( string -- )
	erase-buttons
	2 swap 22 swap grid-type
	wait
	erase-buttons
;

: difficulty site @ diffs   + @ ;
: site-posts site @ posts   + @ ;
: site-mine  site @ myposts + @ ;

: random-message ( table count -- )
	RN @ swap mod + @ message
;

:string mf1 "Your brilliant advice went unheeded."
:string mf2 "These cretins will not be educated!"
:string mf3 "  The ignorant masses ignore you."
:data moderate-fail mf1 mf2 mf3 
:const moderate-fail-count 3

:string ms1 "Your moderation improved the forum!"
:string ms2 "  You have imparted great wisdom!"
:string ms3 " Your genius has enriched the forum!"
:data moderate-succeed ms1 ms2 ms3
:const moderate-succeed-count 3

: moderate
	site @ diffs + @ 6 < -if
		"They are not accepting moderators..." message
		exit
	then
	difficulty 30 * work
	RN @ 100 mod 70 > if
		moderate-succeed moderate-succeed-count random-message
		site @ diffs + inc@
		difficulty 20 * give-cred
	else
		moderate-fail moderate-fail-count random-message
	then
;

: post
	difficulty 20 * work
	RN @ 100 mod 90 < if
		"   You posted an eloquent missive." message
		site @ myposts + inc@
		difficulty give-cred
	else
		" You insulted a moderator. Whoops." message
		difficulty -1 * give-cred
	then
;

: read
	difficulty 10 * work
	site-posts 0 > if
		site-mine 0 > if
			"         You got a reply!" message
		else
			"The fools have not read your message." message
		then
	else
		"   No posts since your last visit." message
	then
	site-posts difficulty * give-cred
	0 site @ posts   + !
	0 site @ myposts + !
;

:data buttonlogic post read moderate

: delay loop clock sync KY @ while ;

: main
	reset-game
	" Press space to begin. " message
	
	loop
		draw-sites
		draw-marquee
		draw-buttons
		
		KY @ dup dup dup
		key-lf and if prevsite site !     delay then
		key-rt and if nextsite site !     delay then
		key-up and if prevbutton button ! delay then
		key-dn and if nextbutton button ! delay then
		
		KY @ key-a and if button @ buttonlogic + @ exec then

		timesup if
			draw-time
			0 give-cred
			erase-buttons
			15 22 "OUTTATIME!" grid-type
			wait
			erase-buttons
			reset-game
		then
		
		clock
		sync
	again
;