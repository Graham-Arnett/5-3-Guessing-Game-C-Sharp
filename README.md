Still working on this, I just feel kind of tired right now. EDIT: Coming back to this four hours later on the same day I have realized 2 of my issues. 
1)tries (the variable I was using to check how many times you've guessed) was not properly incrementing, but we need to track it so we can display different win messages
2)the answer was not changing between rounds. For example if the answer is 50, and you hit 'y' to continue currently, you could enter 50 again because its still the answer, the random hadn't changed
I intend to fix both of these.
