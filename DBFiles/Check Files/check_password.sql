create or replace function sf_check_password
(
    p_password in admins.password%type
)
return int
deterministic
as
    v_password_char char(1);
    v_i int;
begin
    if p_password is null then
        return 0;
    end if;
    
	if length(trim(p_password)) < 6 then
		return 0
	end if;
	  
    return 1;
end sf_check_password;
        