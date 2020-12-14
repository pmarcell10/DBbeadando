create or replace procedure spInsert_admins(
    p_username in admins.username%type,
    p_password in admins.password%type,
    p_out_rowcnt out int
)
authid definer
as
    v_check_password int;
begin
    p_out_rowcnt := 0;
    v_check_password := sf_check_password(p_password);
    if v_check_password = 1 then
        insert into admins (id, username, password) 
        values (seq_item.nextval, p_username, p_password);
        p_out_rowcnt := SQL%rowcount;
        commit;
    end if;
end spInsert_admins;