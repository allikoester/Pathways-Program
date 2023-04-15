let sales: number = 123_456_789;
let course: string = 'TypeScript';
let is_publised: boolean = true;


// ARRAY
let numbers: number[] = [1, 2, 3];
let numberss: number[] = [];

// n. provides lots of different functions
numberss.forEach(n => n.toString)



// TUPLE
let user: [number, string] = [1, 'Alli'];

// can access different properties and methods with element. 
user[0].toFixed;
user.push();

// Enum
// const small = 1;
// const medium = 2;
// const large = 3;
// PascalCase
const enum Size { Small = 0, Medium = 1, Large = 2 };
// !!! Putting const in front of enum helps when compiling to JS

// or can do strings like:
enum Sizes { Small = 's', Medium = 'm', Large = 'l' };

let mySize: Size = Size.Medium;
// reports out 1



// FUNCTIONS

function calculateTax(income: number, taxYear: number): number /*(this is the return type)*/ {
    if (taxYear < 2022)
        return income * 1.2;
    return income * 1.3;
}
// can make parameter passed optional by adding a ?
// example: (income?: number, taxYear?: number)
function calculateTax2(income: number, taxYear = 2022): number {
    if (taxYear < 2022)
        return income * 1.2
    return income * 1.3
}

// OR 

function calculateTax3(income: number, taxYear?): number {
    if ((taxYear || 2022) < 2022)
        return income * 1.2
    return income * 1.3
}

calculateTax(10_000, 2022);
calculateTax2(10000, 2023); /* 2023 will override 2022*/
calculateTax3(10000);


// OBJECTS
// Messy way to write this out
let employee: {
    readonly id: number,
    name?: string,
    retire: (date: Date) => void;
} = {
    id: 1,
    name: 'Alli',
    retire: (date: Date) => {
        console.log(date);
    }
};

// Can make a property option with a ?
// Adding readonly makes it so cannot be changed

// Better way to write this out!!
// Using a type alias
type Employee = {
    id: number,
    name: string,
    retire: (date: Date) => void;
}
let employee2: Employee = {
    id: 2,
    name: 'Allison',
    retire: function (date: Date): void {
        throw new Error("Function not implemented.");
    }
}



// UNION TYPES
function kgToLbs(weight: number | string): number {
    // Narrowing down to more specific type
    if (typeof weight === 'number')
        return weight * 2.2;
    else
        return parseInt(weight) * 2.2;
}

kgToLbs(10);
kgToLbs('10kg');



// INTERSECTION TYPES
type Draggable = {
    drag: () => void
};

type Resizable = {
    resize: () => void
};

type UIWidget = Draggable & Resizable;

let textBox: UIWidget = {
    drag: () => { },
    resize: () => { }
}


// LITERAL TYPES
// Literal (exact, specific)
let quantity: 50;
let quantity2: 50 | 100;

// Can creat custom type using type Alias
type Quantity = 50 | 100;
let quantity3: Quantity = 100;

type Metric = 'cm' | 'inch';


// NULLABLE TYPES
function greet(name: string | null | undefined) {
    if (name)
        console.log(name.toUpperCase());
    else
        console.log('Hola!');
};


// OPTIONAL CHAINING
type Customer = {
    birthday: Date
};

function getCustomer(id: number): Customer | null | undefined {
    return id === 0 ? null : { birthday: new Date() };
}

let customer = getCustomer(0);

if (customer !== null && customer !== undefined)
    console.log(customer.birthday);

// OR CAN WRITE MORE SIMPLY with:
// Optional property access operator -- the question mark
let customer2 = getCustomer(1);
console.log(customer2?.birthday.getFullYear());

// Optional element access operator -- useful when dealing with arrays
customer?.[0];