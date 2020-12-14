set serveroutput on;
declare
    v_call_uqid int;
    v_uqid items.uqid%type := 'ABCD1234';
begin
v_call_uqid := sf_check_uqid(v_uqid);
    if v_call_uqid = 1 THEN
        DBMS_OUTPUT.PUT_LINE('Helyes az egyedi azonosító. '||v_uqid);
    else
        DBMS_OUTPUT.PUT_LINE('Helytelen az egyedi azonosító. '||v_uqid);
    end if;
end;
        