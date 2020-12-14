set serveroutput on;
declare
    v_call_password int;
    v_password admins.password%type := 'marci';
begin
v_call_password := sf_check_password(v_password);
    if v_call_password = 1 THEN
        DBMS_OUTPUT.PUT_LINE('Helyes a jelszó. '||v_password);
    else
        DBMS_OUTPUT.PUT_LINE('Helytelen a jelszó. '||v_password);
    end if;
end;
        