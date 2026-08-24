namespace ConsoleApp1
{
    class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"{Id} | {Name} | {Department} | {Salary:C}";
        }
    }
    internal class Program

    {
        static Dictionary<string, Employee> employeeDict = new Dictionary<string, Employee>();
        static List<Employee> employeeList = new List<Employee>();

        static void Main(string[] args)
        {
            //    dynamic money = 10;

            //    int years = 1;
            //    while (years <= 50)
            //    {
            //        money += money * 0.05;
            //        years++;
            //    }
            //    Console.WriteLine(money);

            //    List<int> list = new List<int>()
            //{
            //    1,
            //    2,
            //    3,
            //    4,
            //};
            //    for (int i = 0; i < list.Count;i++) 
            //    {
            //        Console.WriteLine(list[i]);
            //    }

           



      
            
                // 初始化数据
                AddEmployee("E001", "张三", "技术部", 8000);
                AddEmployee("E002", "李四", "市场部", 6500);
                AddEmployee("E003", "王五", "技术部", 9000);
                AddEmployee("E004", "赵六", "人事部", 5500);
                AddEmployee("E005", "孙七", "市场部", 7000);

                while (true)
                {
                    Console.WriteLine("\n========== 员工工资管理系统 ==========");
                    Console.WriteLine("1. 显示所有员工");
                    Console.WriteLine("2. 添加员工");
                    Console.WriteLine("3. 删除员工");
                    Console.WriteLine("4. 修改工资");
                    Console.WriteLine("5. 按部门统计");
                    Console.WriteLine("6. 工资排名");
                    Console.WriteLine("7. 查找员工");
                    Console.WriteLine("8. 退出");
                    Console.Write("请选择操作: ");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1": ShowAllEmployees(); break;
                        case "2": AddEmployeeFromInput(); break;
                        case "3": DeleteEmployee(); break;
                        case "4": UpdateSalary(); break;
                        case "5": StatisticsByDepartment(); break;
                        case "6": SalaryRanking(); break;
                        case "7": FindEmployee(); break;
                        case "8": Console.WriteLine("再见！"); return;
                        default: Console.WriteLine("无效输入"); break;
                    }
                }
            }

            // 添加员工（内部方法）
            static void AddEmployee(string id, string name, string dept, decimal salary)
            {
                var emp = new Employee { Id = id, Name = name, Department = dept, Salary = salary };
                employeeDict[id] = emp;
                employeeList.Add(emp);
            }

            // 1. 显示所有员工
            static void ShowAllEmployees()
            {
                Console.WriteLine("\n=== 所有员工 ===");
                foreach (var emp in employeeList.OrderBy(e => e.Id))
                {
                    Console.WriteLine(emp);
                }
            }

            // 2. 添加员工（用户输入）
            static void AddEmployeeFromInput()
            {
                Console.Write("请输入工号: ");
                string id = Console.ReadLine();

                if (employeeDict.ContainsKey(id))
                {
                    Console.WriteLine($"❌ 工号 {id} 已存在");
                    return;
                }

                Console.Write("请输入姓名: ");
                string name = Console.ReadLine();
                Console.Write("请输入部门: ");
                string dept = Console.ReadLine();
                Console.Write("请输入工资: ");
                if (!decimal.TryParse(Console.ReadLine(), out decimal salary))
                {
                    Console.WriteLine("❌ 工资格式错误");
                    return;
                }

                AddEmployee(id, name, dept, salary);
                Console.WriteLine($"✅ 员工 {name} 添加成功");
            }

            // 3. 删除员工
            static void DeleteEmployee()
            {
                Console.Write("请输入要删除的工号: ");
                string id = Console.ReadLine();

                if (!employeeDict.ContainsKey(id))
                {
                    Console.WriteLine($"❌ 工号 {id} 不存在");
                    return;
                }

                string name = employeeDict[id].Name;
                employeeDict.Remove(id);
                employeeList.RemoveAll(e => e.Id == id);
                Console.WriteLine($"✅ 员工 {name} 已删除");
            }

            // 4. 修改工资
            static void UpdateSalary()
            {
                Console.Write("请输入工号: ");
                string id = Console.ReadLine();

                if (!employeeDict.ContainsKey(id))
                {
                    Console.WriteLine($"❌ 工号 {id} 不存在");
                    return;
                }

                Console.Write("请输入新工资: ");
                if (!decimal.TryParse(Console.ReadLine(), out decimal newSalary))
                {
                    Console.WriteLine("❌ 工资格式错误");
                    return;
                }

                employeeDict[id].Salary = newSalary;
                Console.WriteLine($"✅ 工资已更新为 {newSalary:C}");
            }

            // 5. 按部门统计
            static void StatisticsByDepartment()
            {
                Console.WriteLine("\n=== 部门统计 ===");
                var deptGroups = employeeList.GroupBy(e => e.Department);

                foreach (var group in deptGroups)
                {
                    Console.WriteLine($"\n{group.Key}:");
                    Console.WriteLine($"  总工资: {group.Sum(e => e.Salary):C}");
                    Console.WriteLine($"  平均工资: {group.Average(e => e.Salary):C}");
                    Console.WriteLine($"  人数: {group.Count()}");
                }
            }

            // 6. 工资排名
            static void SalaryRanking()
            {
                Console.WriteLine("\n=== 工资排名（从高到低）===");
                var sorted = employeeList.OrderByDescending(e => e.Salary);
                int rank = 1;
                foreach (var emp in sorted)
                {
                    Console.WriteLine($"第{rank}名: {emp.Name} - {emp.Salary:C} ({emp.Department})");
                    rank++;
                }
            }

            // 7. 查找员工
            static void FindEmployee()
            {
                Console.Write("请输入工号: ");
                string id = Console.ReadLine();

                if (employeeDict.TryGetValue(id, out Employee emp))
                {
                    Console.WriteLine("\n=== 员工信息 ===");
                    Console.WriteLine($"工号: {emp.Id}");
                    Console.WriteLine($"姓名: {emp.Name}");
                    Console.WriteLine($"部门: {emp.Department}");
                    Console.WriteLine($"工资: {emp.Salary:C}");
                }
                else
                {
                    Console.WriteLine($"❌ 工号 {id} 不存在");
                }
            }
        }
    }

     
    

