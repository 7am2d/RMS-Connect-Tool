SELECT  S.ID, 
		S.Name, 
		L.EventTime, 
		L.EventMessage
FROM	ClueTest.dbo.Store AS S  
JOIN	ClueTest.dbo.HQEventLog AS L
ON S.ID= L.StoreID
WHERE	
L.EventTime > '2015-11-5 01:34' 
AND S.ID = 63
AND L.EventMessage NOT LIKE '%Download%'
AND L.EventMessage NOT LIKE 'Upload%'
AND L.EventMessage NOT LIKE 'Receive%'
AND L.EventMessage NOT LIKE 'Created%'
AND L.EventMessage NOT LIKE 'Update%'
AND L.EventMessage NOT LIKE 'Deleted%'
AND L.EventMessage NOT LIKE 'Synchronized%'
AND L.EventMessage NOT LIKE 'Store-HQ Time%'
AND L.EventMessage NOT LIKE 'Local and HQ%'
AND L.EventMessage NOT LIKE 'Opening of local %'
AND L.EventMessage NOT LIKE 'Closed local %'
AND L.EventMessage != '======= CONNECTION ENDED ======='
ORDER BY S.Name
