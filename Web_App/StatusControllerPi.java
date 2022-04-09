class StatusControllerPi {

	/**
	 * @return pageNotFound error message.
	 */
	public static String[] pageNotFound(){
		String[] pageNotFound = {"Página não encontrada!","404","Warning" };
		return pageNotFound;
	}
	/**
	 * @return created error message.
	 */
	public static String[] created(){
		String[] created = {"Cadastrado com sucesso!","201","Sucess" };
		return created;
	}
	/**
	 * @return nonCreated error message.
	 */
	public static String[] nonCreated(){
		String[] nonCreated = {"Cadastro não realizado!","400","Warning" };
		return nonCreated;
	}
	/**
	 * @return updated error message.
	 */
	public static String[] updated(){
		String[] updated = {"Cadastro atualizado com sucesso!","201","Sucess" };
		return updated;
	}
	/**
	 * @return nonUpdated error message.
	 */
	public static String[] nonUpdated(){
		String[] nonUpdated = {"Cadastro nãoo atualizado!","400","Warning" };
		return nonUpdated;
	}
	/**
	 * @return loginFail error message.
	 */
	public static String[] loginFail(){
		String[] loginFail = {"E-mail e/ou senha inválido(s)!","401","Warning" };
		return loginFail;
	}
	/**
	 * @return unauthorized error message.
	 */
	public static String[] unauthorized(){
		String[] unauthorized = {"Acesso não permitido!","401","Warning" };
		return unauthorized;
	}
	/**
	 * @return internalError error message.
	 */
	public static String[] internalError(){
		String[] internalError = {"Erro interno!","500","Error" };
		return internalError;
	}
	/**
	 * @return notAcceptable error message.
	 */
	public static String[] notAcceptable(){
		String[] notAcceptable = {"Dados Inválidos!","406","Warning" };
		return notAcceptable;
	}
	/**
	 * @return deleted error message.
	 */
	public static String[] deleted(){
		String[] deleted = {"Cadastro deletado!","201","Sucess" };
		return deleted;
	}
	/**
	 * @return nonDeleted error message.
	 */
	public static String[] nonDeleted(){
		String[] nonDeleted = {"Cadastro não deletado!","400","Warning" };
		return nonDeleted;
	}

	}

