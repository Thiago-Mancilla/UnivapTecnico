import mysql.connector
from prettytable import PrettyTable

def abrebanco():
    try:
        global conexao
        conexao = mysql.connector.Connect(host='localhost',database='univap',
        user='root', password='')
        if conexao.is_connected():
            informacaobanco = conexao.get_server_info()
            #print(f'Conectado ao servidor banco de dados - Versão {informacaobanco}')
            #print('Conexão ok')
            global comandosql
            comandosql = conexao.cursor()
            comandosql.execute('select database();')
            nomebanco = comandosql.fetchone()
            #print(f'Banco de dados acessado = {nomebanco}')
            #print('='*80)
            return True
        else:
            print('Conexão não realizada com banco')
        return False
    except Exception as erro:
        print(f'Erro : {erro}')
        return False


"""
DISCIPLINAS
"""
def isDisciplina(cd):
    try:
        comandosql = conexao.cursor()
        sql = f" select COUNT(*) as qtd from disciplinas where codigodisc = {cd};"
        comandosql.execute(sql)
        consulta = comandosql.fetchone()
        if consulta[0] == 1:
            return True
        else:
            return False
    except Exception as erro :
        print(f'Erro: {erro}')
        return False
    
def mostratodasdisciplinas():
    grid = PrettyTable(['Códigos das Disciplinas', "Nomes de Disciplinas"])
    try:
        comandosql = conexao.cursor()
        comandosql.execute(f'select * from disciplinas;')
        tabela = comandosql.fetchall()
        if comandosql.rowcount > 0:
            for registro in tabela:
                grid.add_row([registro[0], registro[1]])
            print(grid)
        else:
            print('Não existem disciplinas cadastradas!!!')
    except Exception as erro:
        print(f'Ocorreu erro: {erro}')


def consultardisciplina(cd=0):
    try:
        comandosql = conexao.cursor()
        comandosql.execute(f'select * from disciplinas where codigodisc = {cd};')
        tabela = comandosql.fetchall()
        if comandosql.rowcount > 0:
            for registro in tabela:
                print(f'Nome da Disciplina: {registro[1]}')
                return 'c'
        else:
            return 'nc'
    except Exception as error:
        return (f'Ocorreu erro ao tentar consultar esta disciplina: Erro===>>> {error}')


def cadastrardisciplina(cd=0,nd=''):
    try:
        comandosql = conexao.cursor()
        comandosql.execute(f'insert into disciplinas(codigodisc, nomedisc) values({cd},"{nd}") ;')
        conexao.commit()
        return 'Cadastro da disciplina realizado com sucesso !!!! '
    except Exception as erro :
        print(f'Erro: {erro}')
        return 'Não foi possível cadastrar esta disciplina !!!'


def alterardisciplina(cd=0, nomedisciplina=''):
    try:
        comandosql = conexao.cursor()
        comandosql.execute(f'Update disciplinas SET nomedisc="{nomedisciplina}" where codigodisc = {cd};')
        conexao.commit()
        return 'Disciplina alterada com sucesso !!! '
    except Exception as erro :
        print(f'Erro: {erro}')
        return 'Não foi possível alterada esta disciplina'


def excluirdisciplina(cd=0):
    try:
        comandosql = conexao.cursor()
        comandosql.execute(f'delete from disciplinas where codigodisc = {cd};')
        conexao.commit()
        return 'Disciplina excluída com sucesso !!! '
    except Exception as erro :
        print(f'Erro: {erro}')
        return '\nNão foi possível excluir esta disciplina. Verifique se a disciplina está relacionada com algum curso!'
    

"""
PROFESSORES
"""
def isProfessor(cp):
    try:
        comandosql = conexao.cursor()
        sql = f" select COUNT(*) as qtd from professores where registro = {cp};"
        comandosql.execute(sql)
        consulta = comandosql.fetchone()
        if consulta[0] == 1:
            return True
        else:
            return False
    except Exception as erro :
        print(f'Erro: {erro}')
        return False

def mostratodosprofessores():
    grid = PrettyTable(['Códigos dos Professores', "Nomes de Professores", "Telefones de Professores", "Idades de Professores", "Salário de Professores"])
    try:
        comandosql = conexao.cursor()
        comandosql.execute(f'select * from professores;')
        tabela = comandosql.fetchall()
        if comandosql.rowcount > 0:
            for registro in tabela:
                grid.add_row([registro[0], registro[1], registro[2], registro[3], registro[4]])
            print(grid)
        else:
            print('Não existem professores cadastrados!!!')
    except Exception as erro:
        print(f'Ocorreu erro: {erro}')


def consultarprofessor(cd=0):
    try:
        comandosql = conexao.cursor()
        comandosql.execute(f'select * from professores where registro = {cd};')
        tabela = comandosql.fetchall()
        if comandosql.rowcount > 0:
            for registro in tabela:
                print(f'Nome do Professor: {registro[1]}')
                print(f'Telefone do Professor: {registro[2]}')
                print(f'Idade do Professor: {registro[3]}')
                print(f'Salário do Professor: {registro[4]}')
                return 'c'
        else:
            return 'nc'
    except Exception as error:
        return (f'Ocorreu erro ao tentar consultar este professor: Erro===>>> {error}')

def cadastrarprofessor(cd=0,nd='',tel='',idade=0,salario=0.0):
    try:
        comandosql = conexao.cursor()
        comandosql.execute(f'insert into professores(registro, nomeprof, telefoneprof, idadeprof, salarioprof) values({cd},"{nd}","{tel}",{idade},{salario}) ;')
        conexao.commit()
        return 'Cadastro do professor realizado com sucesso !!!! '
    except Exception as erro :
        print(f'Erro: {erro}')
        return 'Não foi possível cadastrar este professor !!!'

def alterarprofessor(cd=0, nomeprofessor='',tel='',idade=0,salario=0.0):
    try:
        comandosql = conexao.cursor()
        comandosql.execute(f'Update professores SET nomeprof="{nomeprofessor}",telefoneprof="{tel}",idadeprof={idade},salarioprof={salario} where registro = {cd};')
        conexao.commit()
        return 'Professor alterado com sucesso !!! '
    except Exception as erro :
        print(f'Erro: {erro}')
        return 'Não foi possível alterada este professors'

def excluirprofessor(cd=0):
    try:
        comandosql = conexao.cursor()
        comandosql.execute(f'delete from professores where registro = {cd};')
        conexao.commit()
        return 'Professor excluído com sucesso !!! '
    except Exception as erro :
        print(f'Erro: {erro}')
        return '\nNão foi possível excluir este professor. Verifique se o professor está relacionado com algum curso!'




"""
CURSO
"""

def isCurso(cc):
    try:
        comandosql = conexao.cursor()
        sql = f"select COUNT(*) as qtd from disciplinasxprofessores where codigodisciplinanocurso = {cc} ;"
        comandosql.execute(sql)
        consulta = comandosql.fetchone()
        if consulta[0] == 1:
            return True
        else:
            return False
    except Exception as erro :
        print(f'Erro: {erro}')
        return False

def validarCurso(cd,cp):
    try:
        comandosql = conexao.cursor()
        sql = f" select COUNT(*) as qtd from disciplinas, professores where disciplinas.codigodisc = {cd} and professores.registro = {cp};"
        comandosql.execute(sql)
        consulta = comandosql.fetchone()
        if consulta[0] == 1:
            return True
        else:
            return False
    except Exception as erro :
        print(f'Erro: {erro}')
        return False

def cadastrarcurso(cc,cd=0,cp=0, c=0, cg=0, al=0):
    try:
        if validarCurso(cd,cp):
            sql = f'insert into disciplinasxprofessores (codigodisciplinanocurso,coddisciplina,codprofessor, curso, cargahoraria, anoletivo) values ({cc},{cd},{cp},{c},{cg},{al});'
            comandosql.execute(sql)
            conexao.commit()
            return 'Cadastro do curso realizado com sucesso !!!! '
        else:
            return 'Não foi possível cadastrar este curso, verifique se disciplina e professor existem!!!'
    except Exception as erro :
        print(f'Erro: {erro}')
        return 'Erro ao cadastrar relacionamento.'

def consultarcurso(cr=0):
    try:
        comandosql = conexao.cursor()
        comandosql.execute(f'select * from disciplinasxprofessores where codigodisciplinanocurso = {cr};')
        tabela = comandosql.fetchall()
        if comandosql.rowcount > 0:
            for registro in tabela:
                print(f'Codigo de Relacionamento: {registro[0]}')
                print(f'Codigo da Disciplina: {registro[1]}')
                print(f'Codigo do Professor: {registro[2]}')
                print(f'Curso: {registro[3]}')
                print(f'Carga Horária: {registro[4]}')
                print(f'Ano Letivo: {registro[5]}')
                return 'c'
        else:
            return 'nc'
    except Exception as error:
        return (f'Ocorreu erro ao tentar consultar este professor: Erro===>>> {error}')

def mostratodoscursos():
    grid = PrettyTable(['Códigos dos Relacionamentos', "Nomes das Disciplinas","Codigos das Disciplinas","Nomes dos Professores","Codigos dos Professores", "Curso", "Carga Horária", "Ano Letivo"])
    try:
        comandosql = conexao.cursor()
        comandosql.execute(
            """
            select 
                disciplinasxprofessores.codigodisciplinanocurso, 
                disciplinas.nomedisc, 
                disciplinasxprofessores.coddisciplina,
                professores.nomeprof,
                disciplinasxprofessores.codprofessor,
                disciplinasxprofessores.curso,
                disciplinasxprofessores.cargahoraria,
                disciplinasxprofessores.anoletivo
            from 
                disciplinasxprofessores 
            inner join 
                disciplinas on disciplinasxprofessores.coddisciplina = disciplinas.codigodisc
            inner join 
                professores on disciplinasxprofessores.codprofessor = professores.registro;""")
        tabela = comandosql.fetchall()
        if comandosql.rowcount > 0:
            for registro in tabela:
                grid.add_row([registro[0], registro[1], registro[2],registro[3],registro[4],registro[5], registro[6], registro[7]])
            print(grid)
        else:
            print('Não existem relacionamentos entre professores e disciplinas!!!')
    except Exception as erro:
        print(f'Ocorreu erro: {erro}')


def alterarCurso(cd,cp,cc, c, ch, al):
    try:
        if isDisciplina(cd) and isProfessor(cp):
            comandosql = conexao.cursor()
            comandosql.execute(f'update disciplinasxprofessores set coddisciplina = {cd},codprofessor = {cp}, curso = {c}, cargahoraria = {ch}, anoletivo = {al} where codigodisciplinanocurso = {cc};')
            conexao.commit()
            return 'Relacionamento alterado com sucesso !!! '
    except Exception as erro :
        print(f'Erro: {erro}')
        return 'Não foi possível alterar este relacionamento.'

def excluirCurso(cc):
    try:
        comandosql = conexao.cursor()
        comandosql.execute(f'delete from disciplinasxprofessores where codigodisciplinanocurso = {cc};')
        conexao.commit()
        return 'Curso excluído com sucesso !!! '
    except Exception as erro :
        print(f'Erro: {erro}')
        return 'Não foi possível excluir este curso'



"""
MODULOS
"""
def moduloDisciplinas():
    while resp =='1':
        print('='*80)
        print('{:^80}'.format('SISTEMA UNIVAP - DISCIPLINAS'))
        print('='*80)
        while True:
            codigodisc = input('Código da Disciplina: (0- Mostra Todas OU Enter para sair) ')
            if codigodisc.isnumeric():
                codigodisc = int(codigodisc)
                break
            if codigodisc == '':
                break
        if codigodisc == '': 
            break
        elif codigodisc == 0:
            mostratodasdisciplinas()
            continue
        if consultardisciplina(codigodisc) == 'nc':
            nomedisciplina = input('Nome da Disciplina: ')
            msg = cadastrardisciplina(codigodisc, nomedisciplina)
            print(msg)
        else:
            op = input("Escolha: [A]-Alterar [E]-Excluir [C]-Cancelar Operações ==> ").upper()
            while op!='A' and op!='E' and op!='C':
                op = input("ERRO !!! Escolha CORRETAMENTE : [A]-Alterar [E]-Excluir [C]-Cancelar Operações ==> ").upper()
            if op=='A':
                print('Atenção: Código da disciplina não pode ser alterado: ')
                nomedisciplina = input('Informe novo nome da disciplina: ')
                msg = alterardisciplina(codigodisc, nomedisciplina)
                print(msg)
            elif op == 'E':
                confirma = input('ATENÇÃO !!!! TEM CERTEZA, CONFIRMA EXCLUSÃO? S-SIM OU N-NÃO: ').upper()
                while confirma != 'S' and confirma != 'N':
                    confirma = input('RESPOSTA INEXISTENTE !!!! TEM CERTEZA, CONFIRMA EXCLUSÃO? S-SIM OU N-NÃO: ').upper()
                msg = excluirdisciplina(codigodisc)
                print (msg)

        print('\n\n')
        print('='*80)
        if input('Deseja continuar usando o modulo DISCIPLINAS? 1-Sim OU qualquer tecla para sair:') == '1':
            continue
        else:
            break

def moduloProfessores():
    while resp == '2':
        print('='*80)
        print('{:^80}'.format('SISTEMA UNIVAP - PROFESSORES'))
        print('='*80)
        while True:
            codigoprof = input('Código do Professor: (0- Mostra Todos OU Enter para sair) ')
            if codigoprof.isnumeric():
                codigoprof = int(codigoprof)
                break
            if codigoprof == '':
                break
        if codigoprof == '': 
            break
        elif codigoprof == 0:
            mostratodosprofessores()
            continue
        if consultarprofessor(codigoprof) == 'nc':
            nomeprof = input('Nome do professor: ')
            while(nomeprof == ""):
                nomeprof = input("Digite nome válido: ")
            telefoneprof = input('Telefone do professor: ')
            while(telefoneprof == ""):
                telefoneprof = input("Digite telefone válido: ")
            idadeprof = input('Idade do professor: ')
            while idadeprof.isnumeric() == False:
                idadeprof = input('Apenas será aceito valores numéricos! Digite a idade novamente: ')
            idadeprof = int (idadeprof)
            salarioprof = input('Salario do professor: ')
            while salarioprof.isalnum() == False:
                salarioprof = input('Apenas será aceito valores numéricos! Digite o salário novamente: ')
            salarioprof = float (salarioprof)
            msg = cadastrarprofessor(codigoprof,nomeprof, telefoneprof, idadeprof, salarioprof)
            print(msg)
        else:
            op = input("Escolha: [A]-Alterar [E]-Excluir [C]-Cancelar Operações ==> ").upper()
            while op!='A' and op!='E' and op!='C':
                op = input("ERRO !!! Escolha CORRETAMENTE : [A]-Alterar [E]-Excluir [C]-Cancelar Operações ==> ").upper()
            if op == 'A':
                print('Atenção: Código do Professor não pode ser alterado: ')
                nomeprof = input('Nome do professor: ')
                while(nomeprof == ""):
                    nomeprof = input("Digite nome válido: ")
                telefoneprof = input('Telefone do professor: ')
                while(telefoneprof == ""):
                    telefoneprof = input("Digite telefone válido: ")
                idadeprof = input('Idade do professor: ')
                while idadeprof.isnumeric() == False:
                    idadeprof = input('Apenas será aceito valores numéricos! Digite a idade novamente: ')
                idadeprof = int (idadeprof)
                salarioprof = input('Salario do professor: ')
                while salarioprof.isalnum() == False:
                    salarioprof = input('Apenas será aceito valores numéricos! Digite o salário novamente: ')
                salarioprof = float (salarioprof)
                msg = alterarprofessor(codigoprof,nomeprof,telefoneprof,idadeprof,salarioprof)
                print(msg)
            elif op == 'E':
                confirma = input('ATENÇÃO !!!! TEM CERTEZA, CONFIRMA EXCLUSÃO? S-SIM OU N-NÃO: ').upper()
                while confirma != 'S' and confirma != 'N':
                    confirma = input('RESPOSTA INEXISTENTE !!!! TEM CERTEZA, CONFIRMA EXCLUSÃO? S-SIM OU N-NÃO: ').upper()
                if confirma == "S":
                    msg = excluirprofessor(codigoprof)
                    print(msg)
                elif confirma == "N":
                    print("Exclusao cancelada")

        print('\n\n')
        print('='*80)
        if input('Deseja continuar usando o modulo PROFESSORES? 1- Sim OU qualquer tecla para sair: ') == '1':
            continue
        else:
            break


def moduloDisciplinasxProfessores():
    while resp == "3":
        print('='*80)
        print('{:^80}'.format('SISTEMA UNIVAP - DISCIPLINAS X PROFESSORES'))
        print('='*80)
        while True:
            codigorelacionamento = input("Código de relacionamento: (0- Mostra Todos) ")
            if codigorelacionamento.isnumeric():
                codigorelacionamento = int(codigorelacionamento)
                break
        if codigorelacionamento == 0:
            mostratodoscursos()
            continue
        
        if consultarcurso(codigorelacionamento) == "nc":
            cadastro = input("Deseja cadastrar relacionamento: [S]-Sim OU qualquer tecla para não ==> ").upper()
            if cadastro == "S":
                coddiscplina = input("Codigo da Disciplina: ")
                while coddiscplina.isnumeric() == False:
                    coddiscplina = input("Digite numero valido para o Codigo da Disciplina: ")
                codprofessor = input("Codigo do Professor: ")
                while codprofessor.isnumeric() == False:
                    codprofessor = input("Digite numero valido para o Codigo do Professor: ")
                curso = input("Curso: ")
                while curso.isnumeric() == False or curso == '':
                    curso = input("Valor inválido! Digite o Curso novamente: ")
                curso = int(curso)
                cargaHoraria = input("Carga Horária: ")
                while cargaHoraria.isnumeric() == False or cargaHoraria == '':
                    cargaHoraria = input("Valor inválido! Digite a Carga Horária novamente: ")
                cargaHoraria = int(cargaHoraria)
                anoLetivo = input("Ano Letivo: ")
                while anoLetivo.isnumeric() == False or anoLetivo == '':
                    anoLetivo = input("Valor inválido! Digite o Ano Letivo novamente: ")
                anoLetivo = int(anoLetivo)
                if isCurso(codigorelacionamento) == False:
                    msg = cadastrarcurso(codigorelacionamento,coddiscplina,codprofessor, curso, cargaHoraria, anoLetivo)
                    print(msg)
                else:
                    print("Dados invalidos!")

        else:
            op = input("Escolha: [A]-Alterar [E]-Excluir [C]-Cancelar Operações ==> ").upper()
            while op!='A' and op!='E' and op!='C':
                op = input("ERRO !!! Escolha CORRETAMENTE : [A]-Alterar [E]-Excluir [C]-Cancelar Operações ==> ").upper()
            if op == 'A':
                coddiscplina = input("Informe novo Codigo da Disciplina: ")
                while coddiscplina.isnumeric() == False:
                    coddiscplina = input("Digite numero valido para o Codigo da Disciplina: ")
                codprofessor = input("Informe novo Codigo do Professor: ")
                while codprofessor.isnumeric() == False:
                    codprofessor = input("Digite numero valido para o Codigo do Professor: ")
                curso = input("Curso: ")
                while curso.isnumeric() == False or curso == '':
                    curso = input("Valor inválido! Digite o Curso novamente: ")
                curso = int(curso)
                cargaHoraria = input("Carga Horária: ")
                while cargaHoraria.isnumeric() == False or cargaHoraria == '':
                    cargaHoraria = input("Valor inválido! Digite a Carga Horária novamente: ")
                cargaHoraria = int(cargaHoraria)
                anoLetivo = input("Ano Letivo: ")
                while anoLetivo.isnumeric() == False or anoLetivo == '':
                    anoLetivo = input("Valor inválido! Digite o Ano Letivo novamente: ")
                anoLetivo = int(anoLetivo)
                if isCurso(codigorelacionamento):
                    print(alterarCurso(coddiscplina,codprofessor,codigorelacionamento, curso, cargaHoraria, anoLetivo))
                else:
                    print("Curso invalido!")
            elif op == 'E':
                confirma = input('ATENÇÃO !!!! TEM CERTEZA, CONFIRMA EXCLUSÃO? S-SIM OU N-NÃO: ').upper()
                while confirma != 'S' and confirma != 'N':
                    confirma = input('RESPOSTA INEXISTENTE !!!! TEM CERTEZA, CONFIRMA EXCLUSÃO? S-SIM OU N-NÃO: ').upper()
                msg = excluirCurso(codigorelacionamento)
                print(msg)

        print('\n\n')
        print('='*80)
        if input('Deseja continuar usando o modulo DISCIPLINAS X PROFESSORES? 1- Sim OU qualquer tecla para sair: ') == '1':
            continue
        else:
            break


'''             
MÓDULO PRINCIPAL
'''

if abrebanco() == True:
    while True:
        resp = input('Escolha o modulo (1-Disciplinas, 2-Professores, 3-Disciplinas-Professores ou qualquer tecla para sair) ==> ')
        if resp == "1":
            moduloDisciplinas()
        elif resp == "2":
            moduloProfessores()
        elif resp == "3":
            moduloDisciplinasxProfessores()
        else: 
            comandosql.close()
            conexao.close()
            break
else:
    print('FIM DO PROGRAMA!!! Algum problema existente na conexão com banco de dados.')
