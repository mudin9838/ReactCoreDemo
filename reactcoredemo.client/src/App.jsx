import { useState, useEffect } from 'react';

const App = () => {
    const [employees, setEmployees] = useState([]);

    const ConsumeAPI =async()=>{
        const response = await fetch("api/employees/employees");
        if (response.ok) {
            const data = await response.json();
            console.log(data);
            setEmployees(data);
        }
    }


   useEffect(() => {
    ConsumeAPI();
   }, []); 
  return (
    <div className='container'>
    <table className='table-bordered table-striped'>
        <thead>
            <tr>
                <th>Name</th>
                <th>Email</th>
                <th>Descption</th>
                <th>Phone</th>
            </tr>
        </thead>
        <tbody>
            {
                employees.map((item)=>(
                    <tr key={item.id}>
                        <td>{item.name}</td>
                        <td>{item.email}</td>
                        <td>{item.description}</td>
                        <td>{item.phone}</td>
                       
                    </tr>
                )
            )}
        </tbody>
    </table>
    </div>
  )
}

export default App