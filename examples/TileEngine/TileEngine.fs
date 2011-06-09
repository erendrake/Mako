######################################################
##
##  TileEngine:
##
##  A demonstration of using the Mako grid for
##  tile-based top-down games with collision.
##
##  The words c-px! and c-py! only update the position
##  of a sprite if doing so does not cause the sprite
##  to collide with the terrain. The word c-actor?
##  returns a flag to indicate if a 16x32 sprite is
##  currently colliding with the terrain, calibrated
##  for 3:4 perspective.
##
##  John Earnest
##
######################################################

:image grid-tiles "LabTiles.png" 8 8
:data  grid

	-1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 
	-1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 
	-1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 15 15 15 15 15 15 15 15 15 15 15 15 15 15 15 15 15 15 15 15 15 15 15 15 -1 -1 -1 -1 -1 
	-1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 15 10  9 11 29 11 10 28 11 14 11 11 15 15 30 30  8  8  8  8  8  8  8 15 -1 -1 -1 -1 -1 
	-1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 15 12 10 28 10 14 11 11 12 10 14 28 15 15 30 30  8  8  8  8  8  8  8 15 -1 -1 -1 -1 -1 
	-1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 15 10 28 13 10 29 12 10 12 13 28 12 15 15 30 30  8  8  8  8  8  8  8 15 -1 -1 -1 -1 -1 
	-1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 15  9 10 28 12 11 11  8 13 12 29 12 15 15 30 30  8  8  8  8  8  8  8 15 -1 -1 -1 -1 -1 
	-1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 15  5  5  1  1  1  1  1  1  1  1  1 15 15  5  5  1  1  1  1  1  1  1 15 -1 -1 -1 -1 -1 
	-1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 15  5  5  1  1  1  1  1  1  1  1  1 15 15  5  5  1  1  1  1  1  1  1 15 -1 -1 -1 -1 -1 
	-1 -1 -1 -1 15 15 15 15 15 15 15 15 15  5  5  1  1  1  1  1  1  1  1  1 15 15  5  5  1  1  1  1  1  1  1 15 -1 -1 -1 -1 -1 
	-1 -1 -1 -1 15 13 11 11 29 28 11 15 15  5  5  1  1  1  1  1  1  1  1  1 28 10  5  5  1  1  1  1  1  1  1 15 -1 -1 -1 -1 -1 
	-1 -1 -1 -1 15 28 29 13 11 11 28 15 15  5  5  1  1  1  1  1  1  1  1  1 11 11  5  5  1  1  1  1  1  1  1 15 -1 -1 -1 -1 -1 
	-1 -1 -1 -1 15 28 12 28 28 12 11 28 12  5  5  1  1  1  1  1  1  1  1  1 28 11  5  6  1  1  1  1  1  1  1 15 -1 -1 -1 -1 -1 
	-1 -1 -1 -1 15 12 13 11 12 11 10 28 12  5  5  1  1  1  1  1  1  1  1  1 11 10  6  1  1  1  1  1  1  1  1 15 -1 -1 -1 -1 -1 
	-1 -1 -1 -1 15  5  5  1  1  1  1 13 11  5  6  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1 15 -1 -1 -1 -1 -1 
	-1 -1 -1 -1 15  5  5  1  1  1  1 12 28  6  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1 15 -1 -1 -1 -1 -1 
	-1 -1 -1 -1 15  5  5  1  1  1  1  7  7  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1 15 -1 -1 -1 -1 -1 
	-1 -1 -1 -1 15  5  5  1  1  1  1  7  7  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1 15 -1 -1 -1 -1 -1 
	-1 -1 -1 -1 15  5  5  1  1  1  1  7  7  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1 15 -1 -1 -1 -1 -1 
	-1 -1 -1 -1 15  5  5  1  1  1  1  7  7  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1 15 -1 -1 -1 -1 -1 
	-1 -1 -1 -1 15  5  5  1  1  1  1 15 15  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1 15 -1 -1 -1 -1 -1 
	-1 -1 -1 -1 15 15 15 15 15 15 15 15 15 15 15 15 15 15 15 15 15 15 15 15 15 15 15 15 15 15 15 15 15 15 15 15 -1 -1 -1 -1 -1 
	-1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 
	-1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1
	-1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 
	-1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 
	-1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1  
	-1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 
	-1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 
	-1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 
	-1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 

:image sprite-tiles "Scrubby.png" 16 32
:array sprites 1024 

:data sprite-id
	 0  1  2  3  4  5  6  7
	 8  9 10 11 12 13 14 15

:const player-id 0
:const janet-id  1
:const bill-id   2
:const meg-id    3

: player player-id sprite-id + @ ;
: janet  janet-id  sprite-id + @ ;
: bill   bill-id   sprite-id + @ ;
: meg    meg-id    sprite-id + @ ;

:include "../Sprites.fs"
:include "../Print.fs"

:  rot   >r swap r> swap ; # (a b c -- b c a)
: -rot   swap >r swap r> ; # (a b c -- c a b)
: swap@  2dup @ >r @ swap ! r> swap ! ;

: tile@ ( x y -- tile-index )
	# tile-id = m[((y/8) * (41 + m[GS])) + (x/8) + m[GP]]
	8 / GS @ 41 + * swap 8 / + GP @ + @
;

: c-tile? ( x y -- flag )
	# By following the simple rule that tiles
	# on the left side of the tile sheet are
	# passable and the tiles on the right side
	# are impassible, there's no need to
	# store collision data separately or
	# use a complex lookup table:

	tile@ 16 mod 7 >
;

: c-actor? ( sprite-id -- flag )
	sprite@ dup .sprite-x @ swap .sprite-y @
	swap  1 + swap 24 +
	over 13 + over  7 + c-tile? >r
	over 13 + over      c-tile? r> or >r
	over  7 + over  7 + c-tile? r> or >r
	over  7 + over      c-tile? r> or >r
	over      over  7 + c-tile? r> or >r
	                    c-tile? r> or
;

: c-px! ( x sprite-id )
	dup px >r dup >r px!
	r> r> swap dup c-actor?
	if px! else 2drop then
;

: c-py! ( x sprite-id )
	dup py >r dup >r py!
	r> r> swap dup c-actor?
	if py! else 2drop then
;

: indexof (value array)
	loop
		2dup @ xor
		-if swap drop exit then
		1 +
	again
;

# sort sprite drawing orders by their
# y-coordinates for simulated perspective.
# sprite 'ids' should be fetched through
# the sprite-id table, which is sorted
# in lockstep with sprite registers.
: sort-sprites

	15 for
		i
		i for
			dup py i py <
			if drop i then
		next

		# swap mappings in the id table:
		dup sprite-id indexof
		i sprite-id indexof swap@

		# swap a pair of sprite entries:
		sprite@ i sprite@
		3 for
			over i +
			over i +
			swap@
		next
		2drop

	next
;

# wait for key-a to be pressed
# and then released before continuing.
: wait
	85 GP @ 1186 + !
	loop keys key-a and  if break then sync again
	loop keys key-a and -if break then sync again
	-1 GP @ 1186 + !
;

# What offset needs to be added to an
# ASCII character to get the appropriate
# grid tile index?
:const text-offset  48
:const text-start-x  3
:const text-start-y 25

# Draw a series of strings to the display.
# The address provided should point to a
# line count followed by a series of
# null-terminated strings.
: show-text (msg* -- )

	dup @ swap 1 + swap 1 -
	for
		28 i - 41 * text-start-x + GP @ + >r
		loop
			dup @ dup
			-if drop break then			
			text-offset + i !

			# sync while the text is drawn
			# to create a 'typewriter' effect:
			sync
			1 + r> 1 + >r
		again
		r> drop 1 +
	next
	drop
	
	wait

	# clear the text area
	163 for
		-1 GP @ text-start-y 41 * + i + !
	next
;

# return true if a point lies within
# a given sprite, respecting its current
# location and size.
: c-sprite? ( x y sprite-id -- flag )

	rot >r sprite@ >r
	i .sprite-y @
	2dup i .sprite-h +
	<= -rot >= and
	
	r> r> swap >r
	i .sprite-x @
	2dup r> .sprite-w +
	<= -rot >= and

	and
;

# return true if the player is in
# the right position and facing direction
# for a 'use action' to activate an npc:
: use-object ( sprite -- flag )
	>r
	player sprite@ @ sprite-mirror-horiz and
	if   # facing right
		player px 24 +
		player py 24 +
	else # facing left
		player px  8 -
		player py 24 +
	then
	r> c-sprite?
;

: face-player ( sprite -- )
	dup px player px >
	if face-left else face-right then
;

:var   flipcnt
:var   clipcnt

:data   helo 2
:string $ "     Shouldn't you be, like,"
:string $ "     cleaning or something?"

:data   laugh 1
:string $ "     Tee hee hee!"

: main

(
	# test c-sprite?
	# you must include "../Print.fs"
	32x32 1 sprite@ !
	32  1 px!
	64  1 py!
	 32  64 1 c-sprite? . # -1 expected
	 35  68 1 c-sprite? . # -1 expected
	 68  35 1 c-sprite? . #  0 expected
	100 100 1 c-sprite? . #  0 expected
	cr
)

	# init sprite
	16x32 player sprite@ !
	  0 player tile!
	160 player px!
	120 player py!

	# init npc1
	16x32 janet sprite@ !
	  8 janet tile!
	120 janet px!
	 60 janet py!
	200 flipcnt !

	# init npc2
	16x32 bill sprite@ !
	 16 bill tile!
	250 bill px!
	 70 bill py!
	300 clipcnt !

	# init npc3
	16x32 meg sprite@ !
	 20 meg tile!
	 60 meg px!
	130 meg py!

	loop

		keys key-lf and if player px 1 - player c-px! player face-left  then
		keys key-rt and if player px 1 + player c-px! player face-right then
		keys key-up and if player py 1 - player c-py! then
		keys key-dn and if player py 1 + player c-py! then

		# animate npc1
		flipcnt @
		if
			flipcnt @ 1 - flipcnt !
		else
			janet flip-horiz
			RN @ 600 mod 200 + flipcnt !
		then

		# animate npc2
		clipcnt @
		if
			clipcnt @ 1 - clipcnt !
		else
			bill tile 16 xor
			-if  # clipboard is currently up
				17 bill tile!
				50 clipcnt !
			else # clipboard is currently down
				16 bill tile!
				RN @ 600 mod 200 + clipcnt !
			then
		then

		keys key-a and if

			janet use-object if
				janet face-player
				10 janet tile!
				helo show-text
				12 janet tile!
				laugh show-text
				 8 janet tile!
			else
				1 player tile! 10 for sync next
				2 player tile! 10 for sync next
				3 player tile! 10 for sync next
				2 player tile! 10 for sync next
				1 player tile! 10 for sync next
				0 player tile!
			then
		then

		sort-sprites

		sync
	again
;