# Shell Runner #
for ([$, !, %, ^, *, @, ~] in this ) {
    LsIn [$, !, %, ^, *, @, ~] in cConsole.properties ([$ LsEnd]) $ clearAll LsOut
	$ Ls > new [ cConsole.runner ] this LsEnd 
}.cConsole.new > this

cConsole [ properties ] () {
  Ls.header = [ $ ]
	Ls.entry = [ % ]
	Ls.hidden = [ * ]
	Ls.detect = [ @ ]
	Ls.search = [ ~ ]
	Ls.system = [ ^ ]
	Ls.destroy = [ ! ]
	
	Ls.runner = ( this > matches [ $, !, %, *, @, ~, ^ ])
}
