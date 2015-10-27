select *
from(
 select count(codeid) as Countid,codeid
from ProductPrizeInfo
group by codeid ) a join ProductPrizeInfo b on a.codeid = b.codeid
where countid >1
order by  b.codeprice desc