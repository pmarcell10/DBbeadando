create or replace function sf_check_uqid
(
    p_uqid in items.uqid%type
)
return int
deterministic
as
    v_uqid_char char(1);
    v_i int;
begin
    if p_uqid is null then
        return 0;
    end if;
    
    if length(trim(p_uqid)) = 8 then
        v_i := 1;
        while v_i <= 4 loop
            v_uqid_char := substr(p_uqid, v_i, 1);
            if not (ascii('A') <= ascii(v_uqid_char) and ascii(v_uqid_char) <= ascii('Z')) then
                return 0;
            end if;
            v_i := v_i + 1;
        end loop;
        
        while v_i <= 8 loop
            v_uqid_char := substr(p_uqid, v_i, 1);
            if not (ascii('0') <= ascii(v_uqid_char) and ascii(v_uqid_char) <= ascii('9')) then
                return 0;
            end if;
            v_i := v_i + 1;
        end loop;
        return 1;
    end if;
    return 0;
end sf_check_uqid;
        