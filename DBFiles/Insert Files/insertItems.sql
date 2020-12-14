create or replace procedure spInsert_items(
    p_name in items.name%type,
    p_quantity in items.quantity%type,
    p_uqid in items.uqid%type,
    p_out_rowcnt out int
)
authid definer
as
    v_check_uqid int;
begin
    p_out_rowcnt := 0;
    v_check_uqid := sf_check_uqid(p_uqid);
    if v_check_uqid = 1 then
        insert into items (id, name, quantity, uqid) 
        values (seq_item.nextval, p_name, p_quantity, p_uqid);
        p_out_rowcnt := SQL%rowcount;
        commit;
    end if;
end spInsert_items;