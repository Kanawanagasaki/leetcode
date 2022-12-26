SELECT a.`id`
FROM `Weather` a
WHERE a.`temperature` >
    (SELECT b.`temperature`
    FROM `Weather` b
    WHERE b.`recordDate` = SUBDATE(a.`recordDate`, 1)
    LIMIT 1)